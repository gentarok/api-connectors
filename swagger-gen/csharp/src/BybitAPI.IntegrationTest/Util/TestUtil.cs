using System;

namespace BybitAPI.IntegrationTest.Util
{
    internal static class TestUtil
    {
        internal const string TESTNET_URI = "https://api-testnet.bybit.com";

        internal static string GetTestApiKey() => Environment.GetEnvironmentVariable("BYBIT_TEST_API_KEY") ?? throw new NullReferenceException("The environment variable 'BYBIT_TEST_API_KEY' has not been defined.");

        internal static string GetTestApiSecret() => Environment.GetEnvironmentVariable("BYBIT_TEST_API_SECRET") ?? throw new NullReferenceException("The environment variable 'BYBIT_TEST_API_SECRET' has not been  defined.");
    }
}