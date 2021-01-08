using System.Linq;

namespace BybitAPI.Api.Util
{
    internal static class StringExtension
    {
        public static string ToSnakeCase(this string str)
            => string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
    }
}