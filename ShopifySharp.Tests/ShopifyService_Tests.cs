using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShopifyService")]
    public class ShopifyService_Tests
    {
        [Fact]
        public void Returns_Message_About_The_StatusCode()
        {
            var res = new HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                ReasonPhrase = "Internal Server Error",
                Content = new StringContent("{}")
            };
            res.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, "{}");
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
