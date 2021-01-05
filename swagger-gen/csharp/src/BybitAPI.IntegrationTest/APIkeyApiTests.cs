using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;
using System;

namespace BybitAPI.IntegrationTest
{
    public class APIkeyApiTests
    {
        private APIkeyApi instance;

        [SetUp]
        public void Setup()
        {
            var configuration = new Configuration();
            configuration.BasePath = TestUtil.TESTNET_URI;
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            configuration.ApiKey.Add("timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString());
            instance = new APIkeyApi(configuration);
        }

        [Test]
        public void APIkeyInfo_ShouldReturnAPIKeyBase()
        {
            // Arrange

            // Act
            var response = instance.APIkeyInfo();

            // Assert
            Assert.IsInstanceOf<APIKeyBase>(response, "response is APIKeyBase");
            System.Diagnostics.Debug.WriteLine(response);
            Assert.That(response.Result, Has.Exactly(1).Matches<APIKeyInfo>(x => x.ApiKey == TestUtil.GetTestApiKey()));
        }

        [Test]
        public void APIkeyInfoWithHttpInfo_ShouldReturnApiRespenseOfAPIKeyBase()
        {
            // Arrange

            // Act
            var response = instance.APIkeyInfoWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<APIKeyBase>>(response, "response is ApiResponce<APIKeyBase>");
            System.Diagnostics.Debug.WriteLine(response);
            Assert.That(response.Data.Result, Has.Exactly(1).Matches<APIKeyInfo>(x => x.ApiKey == TestUtil.GetTestApiKey()));
        }
    }
}