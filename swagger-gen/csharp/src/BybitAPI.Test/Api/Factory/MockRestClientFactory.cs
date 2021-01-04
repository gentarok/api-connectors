using Moq;
using RestSharp;
using System;
using System.Net;

namespace BybitAPI.Test.Api.Factory
{
    internal static class MockRestClientFactory
    {
        internal static IRestClient Create(HttpStatusCode httpStatusCode, string json)
        {
            var response = new Mock<IRestResponse>();
            response.Setup(_ => _.StatusCode).Returns(httpStatusCode);
            response.Setup(_ => _.Headers).Returns(Array.Empty<Parameter>());
            response.Setup(_ => _.Content).Returns(json);

            var mockIRestClient = new Mock<IRestClient>();
            mockIRestClient
                .Setup(x => x.Execute(It.IsAny<IRestRequest>()))
                .Returns(response.Object);
            mockIRestClient
                .Setup(x => x.ExecuteAsync(It.IsAny<IRestRequest>(), System.Threading.CancellationToken.None))
                .ReturnsAsync(response.Object);

            return mockIRestClient.Object;
        }
    }
}