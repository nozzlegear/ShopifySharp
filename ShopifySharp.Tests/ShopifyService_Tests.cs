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
            var req = new HttpResponseMessage();
            req.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            req.ReasonPhrase = "Internal Server Error";

            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(req, null);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(ex.HttpStatusCode, System.Net.HttpStatusCode.InternalServerError);
            Assert.Contains("Response did not indicate success. Status: 500", ex.Message);
        }
    }
}
