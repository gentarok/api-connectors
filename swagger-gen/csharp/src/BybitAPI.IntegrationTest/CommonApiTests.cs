using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;
using System;

namespace BybitAPI.IntegrationTest
{
    public class CommonApiTests
    {
        private CommonApi instance;

        [SetUp]
        public void Setup()
        {
            var configuration = new Configuration();

            // Prepeare configurations to test.
            configuration.BasePath = TestUtil.TESTNET_URI;
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            configuration.ApiKey.Add("timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString());
            instance = new CommonApi(configuration);
        }

        [Test]
        public void CommonAnnouncements_ShouldReturnAnnouncement()
        {
            // Arrange

            // Act
            var response = instance.CommonAnnouncements();

            // Assert
            Assert.IsInstanceOf<Announcement>(response, "response is Announcement");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }

        [Test]
        public void CommonGetLcp_ShouldReturnLCPInfoBase()
        {
            // Arrange
            string symbol = "BTCUSD";

            // Act
            var response = instance.CommonGetLcp(symbol);

            // Assert
            Assert.IsInstanceOf<LCPInfoBase>(response, "response is LCPInfoBase");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }

        [Test]
        public void CommonGetTime_ShouldReturnServerTime()
        {
            // Arrange

            // Act
            var response = instance.CommonGetTime();

            // Assert
            Assert.IsInstanceOf<ServerTime>(response, "response is ServerTime");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }
    }
}