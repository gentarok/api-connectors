using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace BybitAPI.Api.Util
{
    internal static class ApiUtil
    {
        internal static readonly string[] Intervals = new[] { "1", "3", "5", "15", "30", "60", "120", "240", "360", "720", "D", "M", "W", };

        internal const string MAINNET_URI = "https://api.bybit.com";

        internal const string TESTNET_URI = "https://api-testnet.bybit.com";

        internal static string CreateSignature(string secret, IDictionary<string, string> param)
            => CreateSignature(secret, CreateQueryString(param));

        private static string CreateSignature(string secret, string message)
        {
            var signatureBytes = Hmacsha256(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(message));
            return ByteArrayToString(signatureBytes);
        }

        private static byte[] Hmacsha256(byte[] keyByte, byte[] messageBytes)
        {
            using var hash = new HMACSHA256(keyByte);
            return hash.ComputeHash(messageBytes);
        }

        private static string ByteArrayToString(byte[] byteArray)
        {
            var hex = new StringBuilder(byteArray.Length * 2);

            foreach (var b in byteArray)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        private static string CreateQueryString(IDictionary<string, string> param)
        {
            if (param is null)
            {
                throw new ArgumentNullException(nameof(param));
            }

            var b = new StringBuilder();
            foreach (var item in param)
            {
                b.Append(string.Format("&{0}={1}", item.Key, item.Value));
            }

            // Note: Not Encoded.
            return b.ToString().TrimStart('&');
        }

        internal static IEnumerable<JsonConverter> GetJsonConverters()
        {
            // Add a default String to Enum converter.
            yield return new JsonStringEnumConverter();

            // Add custom converters for nullable enums.
            // Note: System.Text.Json 5.0 does not support to deserialise nullalbe enum. This may be supported in the next or later version.
            // Notice!: The order in which the converters are added is the priority of the converters used by the deserializer, so these converters must be added after the JsonStringEnumConverter.
            var asm = Assembly.GetExecutingAssembly();
            var type = typeof(StringNullableEnumConverter<>);

            // Supports enums defined in the namespace "$(AssemblyName).Model".
            var converters = asm.GetTypes()
                .Where(x => x.IsEnum && x.FullName.StartsWith($"{asm.GetName().Name}.Model"))
                .Select(x =>
                {
                    var nullableType = typeof(Nullable<>).MakeGenericType(x);
                    var converterType = type.MakeGenericType(nullableType);
                    return (JsonConverter)Activator.CreateInstance(converterType);
                });

            foreach (var converter in converters)
            {
                yield return converter;
            }

            // Add a custom DateTimeOffset converter.
            yield return new UtcDateTimeStringToDateTimeOffsetConverter();
        }
    }
}