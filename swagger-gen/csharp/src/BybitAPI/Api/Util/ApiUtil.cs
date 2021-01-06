using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace BybitAPI.Api.Util
{
    internal static class ApiUtil
    {
        internal const string MAINNET_URI = "https://api.bybit.com";

        internal const string TESTNET_URI = "https://api-testnet.bybit.com";

        internal static string CreateSignature(string secret, IDictionary<string, string> param) => CreateSignature(secret, CreateQueryString(param));

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
                throw new ArgumentNullException(nameof(param));

            StringBuilder b = new StringBuilder();
            foreach (var item in param)
            {
                b.Append(string.Format("&{0}={1}", item.Key, WebUtility.UrlEncode(item.Value)));
            }

            return b.ToString().TrimStart('&');
        }
    }
}