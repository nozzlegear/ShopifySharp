using System;
using System.Net.Http;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShopifyService")]
    public class ShopifyService_Tests
    {
        [Fact]
        public void Returns_Message_About_The_StatusCode()
        {
            var req = new Moq.Mock<HttpResponseMessage>();

            req.Setup(r => r.StatusCode).Returns(System.Net.HttpStatusCode.InternalServerError);
            req.Setup(r => r.ReasonPhrase).Returns("Internal Server Error");

            var fakeResponse = req.Object;
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(fakeResponse, null);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(ex.HttpStatusCode, System.Net.HttpStatusCode.InternalServerError);
            Assert.Contains(ex.Message, "Response did not indicate success. Status: 500");
        }
    }
}
