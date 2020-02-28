using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShopifyService")]
    public class ShopifyService_Tests
    {
        HttpResponseMessage BadResponse(HttpStatusCode statusCode, string json)
        {
            var res = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                ReasonPhrase = "Internal Server Error",
                Content = new StringContent(json)
            };
            res.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            return res;
        }
        
        [Fact]
        public void Returns_Message_About_The_StatusCode()
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
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, ex.HttpStatusCode);
            Assert.Contains("Response did not indicate success. Status: 500", ex.Message);
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
            Assert.Equal("errors: foo error message", ex.Message);
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
            Assert.Equal("order: foo error message", ex.Message);
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
            Assert.Equal("order: foo error message", ex.Message);
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
            Assert.Equal("order: foo error message, bar error message", ex.Message);
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
            Assert.Equal("foo: bar", ex.Message);
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
            Assert.Equal("error: location_id must be specified when creating fulfillments.", ex.Message);
        }
        
        [Fact]
        public void Parses_Errors_Of_Type_One()
        {
            var json = "{\"errors\":\"foo error message\"}";

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("errors", error.Key);
                Assert.Single(error.Value);
                Assert.Equal("foo error message", error.Value.First());
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }
        
        // TODO: change error parsing logic to just return a List<string> instead of a dictionary?
        // The key is often constructed by the package and only rarely comes from Shopify instead. 

        [Fact]
        public void Parses_Errors_Of_Type_Two()
        {
            var json = "{\"errors\":{\"order\":\"foo error message\"}}";

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("order", error.Key);
                Assert.Single(error.Value);
                Assert.Equal("foo error message", error.Value.First());
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

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("order", error.Key);
                Assert.Single(error.Value);
                Assert.Equal("foo error message", error.Value.First());
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

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("order", error.Key);
                Assert.Equal(2, error.Value.Count());
                Assert.Equal("foo error message", error.Value.First());
                Assert.Equal("bar error message", error.Value.Last());
            }
            else
            {
                CustomAssert.Fail("TryParseErrorJson failed to parse and returned false.");
            }
        }

        [Fact]
        public void Parses_Errors_Of_Type_Four()
        {
            var json = "{\"error\":\"foo\",\"error_description\":\"bar\"}";

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("foo", error.Key);
                Assert.Single(error.Value);
                Assert.Equal("bar", error.Value.First());
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

            if (ShopifyService.TryParseErrorJson(json, out var dict))
            {
                Assert.Equal(1, dict.Count);

                var error = dict.First();
                
                Assert.Equal("error", error.Key);
                Assert.Single(error.Value);
                Assert.Equal("location_id must be specified when creating fulfillments.", error.Value.First());
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
    }
}
