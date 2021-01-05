using System;

namespace BybitAPI.IntegrationTest.Util
{
    internal static class TestUtil
    {
        internal const string TESTNET_URI = "https://api-testnet.bybit.com";

        internal static string GetTestApiKey() => Environment.GetEnvironmentVariable("BYBIT_TEST_API_KEY");

        internal static string GetTestApiSecret() => Environment.GetEnvironmentVariable("BYBIT_TEST_API_SECRET");
    }
}