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
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
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
            Assert.That(response.RetCode, Is.EqualTo(0));
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
            Assert.That(response.Data.RetCode, Is.EqualTo(0));
            Assert.That(response.Data.Result, Has.Exactly(1).Matches<APIKeyInfo>(x => x.ApiKey == TestUtil.GetTestApiKey()));
        }
    }
}