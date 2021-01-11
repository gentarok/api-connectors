using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BybitAPI.Api.Util
{
    internal class UtcDateTimeStringToDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        // see: https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14
        // see also: https://mattallan.me/posts/rfc3339-date-time-validation/
        private static readonly Regex RegRFC3339 = new Regex(
            @"^(?<fullyear>\d{4})-(?<month>0[1-9]|1[0-2])-(?<mday>0[1-9]|[12][0-9]|3[01])T(?<hour>[01][0-9]|2[0-3]):(?<minute>[0-5][0-9]):(?<second>[0-5][0-9]|60)(?<secfrac>\.[0-9]+)?(Z|(\+|-)(?<offset_hour>[01][0-9]|2[0-3]):(?<offset_minute>[0-5][0-9]))$",
            RegexOptions.Compiled);

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            // if the value matches RFC3339 format, parse value as DateTimeOffset directly.
            if (value is not null && RegRFC3339.IsMatch(value))
            {
                return DateTimeOffset.Parse(value);
            }

            // else, assuming the format of the value is "YYYY-MM-DD HH:MM:SS" in UTC time, parse it into DateTimeOffset.
            // ex: "2020-06-12 08:27:51" -> "2020-06-12T08:27:51 +00:00"

            //TODO: Consider checking the format of the value.
            var dt = DateTime.Parse(value);
            return DateTime.SpecifyKind(dt, DateTimeKind.Utc);
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString());
    }
}