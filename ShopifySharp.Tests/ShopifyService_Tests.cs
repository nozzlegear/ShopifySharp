using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShopifyService"), Trait("Category", "DotNetFramework"), Trait("Category", "Exclusive")]
    public class ShopifyService_Tests
    {
        string ReasonPhrase(HttpStatusCode code)
        {
            switch (code)
            {
                case HttpStatusCode.InternalServerError:
                    return "Internal Server Error";
                
                case HttpStatusCode.BadRequest:
                    return "Bad Request";
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(code));
            }
        }
        
        HttpResponseMessage BadResponse(HttpStatusCode statusCode, string json)
        {
            var res = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                ReasonPhrase = ReasonPhrase(statusCode),
                Content = new StringContent(json)
            };
            res.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            return res;
        }
        
        [Fact]
        public void Returns_Message_Saying_Json_Could_Not_Be_Parsed()
        {
            var json = "{}";
            var res = BadResponse(HttpStatusCode.InternalServerError, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(HttpStatusCode.InternalServerError, ex.HttpStatusCode);
            Assert.Contains("(500 Internal Server Error) Shopify returned 500 Internal Server Error, but ShopifySharp was unable to parse the response JSON.", ex.Message);
        }

        [Fact]
        public void Returns_Message_Saying_There_Was_No_Json_To_Parse()
        {
            var json = "<p>testing</p>";
            var res = BadResponse(HttpStatusCode.InternalServerError, json);
            res.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(HttpStatusCode.InternalServerError, ex.HttpStatusCode);
            Assert.Contains("(500 Internal Server Error) Shopify returned 500 Internal Server Error, but there was no JSON to parse into an error message.", ex.Message);
        }
        
        [Fact]
        public void Exception_Contains_Message_From_Error_Type_One()
        {
            var json = "{\"errors\":\"foo error message\"}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) foo error message", ex.Message);
        }

        [Fact]
        public void Exception_Contains_Message_From_Error_Type_Two()
        {
            var json = "{\"errors\":{\"order\":\"foo error message\"}}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) order: foo error message", ex.Message);
        }

        [Fact]
        public void Exception_Contains_Message_From_Error_Type_Three()
        {
            var json = "{\"errors\":{\"order\":[\"foo error message\"]}}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) order: foo error message", ex.Message);
        }
        
        [Fact]
        public void Exception_Contains_Message_From_Error_Type_Three_With_Multiple_Messages()
        {
            var json = "{\"errors\":{\"order\":[\"foo error message\",\"bar error message\"]}}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) order: foo error message (and one other error)", ex.Message);
            Assert.Equal("order: bar error message", ex.Errors.Last());
        }
        
        [Fact]
        public void Exception_Contains_Message_From_Error_Type_Four()
        {
            var json = "{\"error\":\"foo\",\"error_description\":\"bar\"}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) foo: bar", ex.Message);
        }
        
        [Fact]
        public void Exception_Contains_Message_From_Error_Type_Five()
        {
            var json = "{\"error\":\"location_id must be specified when creating fulfillments.\"}";
            var code = HttpStatusCode.BadRequest;
            var res = BadResponse(code, json);
            ShopifyException ex = null;

            try
            {
                ShopifyService.CheckResponseExceptions(res, json);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(code, ex.HttpStatusCode);
            Assert.Equal("(400 Bad Request) location_id must be specified when creating fulfillments.", ex.Message);
        }
        
        [Fact]
        public void Parses_Errors_Of_Type_One()
        {
            var json = "{\"errors\":\"foo error message\"}";

            if (ShopifyService.TryParseErrorJson(json, out var errors))
            {
                Assert.Single(errors);

                var error = errors.First();
                
                Assert.Equal("foo error message", error);
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }
        
        [Fact]
        public void Parses_Errors_Of_Type_Two()
        {
            var json = "{\"errors\":{\"order\":\"foo error message\"}}";

            if (ShopifyService.TryParseErrorJson(json, out var errors))
            {
                Assert.Single(errors);

                var error = errors.First();
                
                Assert.Equal("order: foo error message", error);
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }

        [Fact]
        public void Parses_Errors_Of_Type_Three()
        {
            var json = "{\"errors\":{\"order\":[\"foo error message\"]}}";

            if (ShopifyService.TryParseErrorJson(json, out var errors))
            {
                Assert.Single(errors);

                var error = errors.First();
                
                Assert.Equal("order: foo error message", error);
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }

        [Fact]
        public void Parses_Errors_Of_Type_Three_With_Multiple_Messages()
        {
            var json = "{\"errors\":{\"order\":[\"foo error message\",\"bar error message\"]}}";

            if (ShopifyService.TryParseErrorJson(json, out var errors))
            {
                Assert.Equal(2, errors.Count());
                Assert.Equal("order: foo error message", errors.First());
                Assert.Equal("order: bar error message", errors.Last());
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }

        [Fact]
        public void Parses_Errors_Of_Type_Five()
        {
            var json = "{\"error\":\"location_id must be specified when creating fulfillments.\"}";

            if (ShopifyService.TryParseErrorJson(json, out var errors))
            {
                Assert.Single(errors);

                var error = errors.First();
                
                Assert.Equal("location_id must be specified when creating fulfillments.", error);
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }

        [Fact]
        public void Returns_False_For_Invalid_Json()
        {
            Assert.False(ShopifyService.TryParseErrorJson("", out _));
            Assert.False(ShopifyService.TryParseErrorJson("text here", out _));
            Assert.False(ShopifyService.TryParseErrorJson("[]", out _));
            Assert.False(ShopifyService.TryParseErrorJson("[1,2,3]", out _));
            Assert.False(ShopifyService.TryParseErrorJson("true", out _));
            Assert.False(ShopifyService.TryParseErrorJson("false", out _));
        }

        [Fact]
        public void Returns_False_For_Json_That_Does_Not_Match_Expected_Formats()
        {
            var json = "{\"error_foo\":\"bar\"}";
            
            Assert.False(ShopifyService.TryParseErrorJson(json, out _));
            
            json = "{\"error_foo\":\"bar\",\"error_description\":\"baz\"}";
            
            Assert.False(ShopifyService.TryParseErrorJson(json, out _));
            
            json = "{\"errors_foo\":\"bar\"}";
            
            Assert.False(ShopifyService.TryParseErrorJson(json, out _));
        }

        [Fact(DisplayName = "Allows setting an instance-specific HttpClient")]
        public async Task Allows_Setting_Instance_Specific_HttpClient()
        {
            var service = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);
            service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            
            // Set the client
            var client = new FakeHttpClient();
            service.SetHttpClient(client);

            var ex = await Assert.ThrowsAsync<Exception>(() => service.GetAsync());
            
            Assert.Equal("This is an exception thrown by the FakeHttpClient", ex.Message);
            
            // Remove the client
            service.SetHttpClient(null);

            var shop = await service.GetAsync();
            
            Assert.NotNull(shop);
        }

        [Fact(DisplayName = "Allows setting a global HttpClientFactory")]
        public async Task Allows_Setting_Global_HttpClientFactory()
        {
            var factory = new FakeHttpClientFactory();
            
            ShopifyService.SetGlobalHttpClientFactory(factory);

            var shopService = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);
            var orderService = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            var policy = new LeakyBucketExecutionPolicy();
            var orderFilter = new OrderListFilter
            {
                Limit = 1
            };
            
            shopService.SetExecutionPolicy(policy);
            orderService.SetExecutionPolicy(policy);
            
            var ex1 = await Assert.ThrowsAsync<Exception>(() => shopService.GetAsync());
            var ex2 = await Assert.ThrowsAsync<Exception>(() => orderService.ListAsync(orderFilter));
            
            Assert.Equal("This is an exception thrown by the FakeHttpClient", ex1.Message);
            Assert.Equal("This is an exception thrown by the FakeHttpClient", ex2.Message);
            
            // Removing the factory should only remove it for future instances
            ShopifyService.SetGlobalHttpClientFactory(null);
            
            ex1 = await Assert.ThrowsAsync<Exception>(() => shopService.GetAsync());
            ex2 = await Assert.ThrowsAsync<Exception>(() => orderService.ListAsync(orderFilter));
            
            Assert.Equal("This is an exception thrown by the FakeHttpClient", ex1.Message);
            Assert.Equal("This is an exception thrown by the FakeHttpClient", ex2.Message);
            
            // Instantiating the services again should now use the default HttpClientFactory
            shopService = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);
            orderService = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            
            shopService.SetExecutionPolicy(policy);
            orderService.SetExecutionPolicy(policy);

            var shop = await shopService.GetAsync();
            var orders = await orderService.ListAsync(orderFilter);
            
            Assert.NotNull(shop);
            Assert.NotNull(orders);
        }

        class FakeHttpClient : HttpClient
        {
            public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                throw new Exception("This is an exception thrown by the FakeHttpClient");
            }
        }

        class FakeHttpClientFactory : IHttpClientFactory
        {
            public HttpClient CreateClient(string name)
            {
                return new FakeHttpClient();
            }
        }
    }
}
