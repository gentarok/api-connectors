#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BybitAPI.Api.Util
{
    internal class StringNullableEnumConverter<T> : JsonConverter<T>
    {
        private readonly JsonConverter<T> _converter;
        private readonly Type? _underlyingType;

        public StringNullableEnumConverter() : this(default)
        {
        }

        public StringNullableEnumConverter(JsonSerializerOptions? options)
        {
            // for performance, use the existing converter if available
            if (options != null)
            {
                _converter = (JsonConverter<T>)options.GetConverter(typeof(T));
            }

            // cache the underlying type
            _underlyingType = Nullable.GetUnderlyingType(typeof(T));
        }

        public override bool CanConvert(Type typeToConvert) => typeof(T).IsAssignableFrom(typeToConvert);

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (_converter is not null)
            {
                return _converter.Read(ref reader, _underlyingType, options);
            }

            var value = reader.GetString();

            if (string.IsNullOrEmpty(value))
            {
                return default;
            }

            // for performance, parse with ignoreCase:false first.
#if NETSTANDARD2_0 ||  NETCOREAPP2_0 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48
            if (!EnumHelper.TryParse(_underlyingType, value, ignoreCase: false, out var result) &&
                !EnumHelper.TryParse(_underlyingType, value, ignoreCase: true, out result))
            {
                throw new JsonException($"Unable to convert \"{value}\" to Enum \"{_underlyingType}\".");
            }
#else
            if (!Enum.TryParse(_underlyingType, value, ignoreCase: false, out var result) &&
                !Enum.TryParse(_underlyingType, value, ignoreCase: true, out result))
            {
                throw new JsonException($"Unable to convert \"{value}\" to Enum \"{_underlyingType}\".");
            }
#endif

            return (T)result;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            => writer.WriteStringValue(value?.ToString());
    }
}

#if NETSTANDARD2_0 || NETCOREAPP2_0 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48

// "Enum.TryParse(Type, string, bool, out object)" is not supported in versions below .NET Standard 2.0,
// and since accessibility is defined as private, so we need to call using reflection.

namespace BybitAPI.Api.Util
{
    using System;
    using System.Reflection;

    internal class EnumHelper
    {
        internal static bool TryParse(Type enumType, string? value, bool ignoreCase, out object? result)
        {
            var mi = typeof(Enum).GetMethod(
                "TryParse",
                BindingFlags.NonPublic | BindingFlags.Static,
                Type.DefaultBinder,
                new[] { typeof(Type), typeof(string), typeof(bool), typeof(bool), typeof(object).MakeByRefType() },
                null);

            var input = new object[] { enumType, value, ignoreCase, false, null };

            if ((bool)mi.Invoke(null, input))
            {
                result = input[4];
                return true;
            }
            result = null;
            return false;
        }
    }
}

#endif

#nullable restore