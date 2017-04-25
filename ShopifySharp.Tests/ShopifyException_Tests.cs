using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShopifyException")]
    public class ShopifyException_Tests
    {
        private IFlurlClient PrepareRequest(string path)
        {
            var client = Flurl.Url.Combine(Utils.MyShopifyUrl, "admin", path)
                .AllowAnyHttpStatus()
                .WithHeader("X-Shopify-Access-Token", Utils.AccessToken);

            return client;
        }

        [Fact]
        public void Throws_On_OAuth_Code_Used()
        {
            string rawBody = "{\"error\":\"invalid_request\",\"error_description\":\"The authorization code was not found or was already used\"}";
            var response = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.NotAcceptable,
                ReasonPhrase = "Not Acceptable"
            };
            ShopifyException ex = null;

            try 
            {
                ShopifyService.CheckResponseExceptions(response, rawBody);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Contains("authorization code was not found or was already used", ex.Message);
            Assert.NotNull(ex.RawBody);
            Assert.Equal(1, ex.Errors.Count);
            Assert.Equal("invalid_request", ex.Errors.First().Key);
            Assert.Equal(1, ex.Errors.First().Value.Count());
        }

        [Fact]
        public async Task Throws_On_Error_String()
        {
            HttpResponseMessage response;
            string rawBody;
            ShopifyException ex = null;

            // This request will return a response which looks like { errors: "some error message"}
            using (var client = PrepareRequest("api_permissions/current.json"))
            {
                var req = client.GetAsync();
                response = await req;
                rawBody = await req.ReceiveString();
            }

            try
            {
                ShopifyService.CheckResponseExceptions(response, rawBody);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(1, ex.Errors.Count);
            Assert.Equal("Error", ex.Errors.First().Key);
            Assert.Equal(1, ex.Errors.First().Value.Count());
        }

        [Fact]
        public async Task Throws_On_Error_Object()
        {
            HttpResponseMessage response;
            string rawBody;
            ShopifyException ex = null;

            while (ex == null)
            {
                // This request will return a response which looks like { errors: { "order" : "some error message" } }
                using (var client = PrepareRequest("orders.json"))
                {
                    var req = client.PostAsync(new JsonContent(new { }));;
                    response = await req;
                    rawBody = await req.ReceiveString();
                }

                try
                {
                    ShopifyService.CheckResponseExceptions(response, rawBody);
                }
                catch (ShopifyRateLimitException)
                {
                    // Ignore this exception and retry the request.
                    // RateLimitExceptions may happen when all Exception tests are running and
                    // execution policies are retrying.
                }
                catch (ShopifyException e)
                {
                    ex = e;
                }
            }

            Assert.NotNull(ex);
            Assert.True(ex.Errors.Count > 0);
            Assert.True(ex.Errors.Any(error => error.Key.Equals("order")));
            Assert.NotNull(ex.Errors.First(err => err.Key.Equals("order")).Value.First());
            Assert.True(ex.Errors.First(err => err.Key.Equals("order")).Value.Count() > 0);
            Assert.True(ex.Errors.All(err => err.Value.Count() > 0));
        }

        [Fact]
        public async Task Throws_On_Error_Arrays()
        {
            //Creating an order with tax lines on both line items and the order will return an error
            var order = new Order()
            {
                CreatedAt = DateTime.UtcNow,
                LineItems = new List<LineItem>()
                {
                    new LineItem()
                    {
                        Title = "Click Keyboard",
                        Price = 99.99,
                        Grams = 600,
                        Quantity = 1,
                        TaxLines = new List<TaxLine>()
                        {
                            new TaxLine()
                            {
                                Price = 1.0,
                                Rate = 0.01,
                                Title = "Keyboard tax"
                            }
                        }
                    }
                },
                TaxLines = new List<TaxLine>()
                {
                    new TaxLine()
                    {
                        Price = 6.0,
                        Rate = 0.06,
                        Title = "State tax"
                    }
                }
            };
            HttpResponseMessage response;
            string rawBody;
            ShopifyException ex = null;
            
            // This request will return a response which looks like { errors: { "order" : [ "some error message" ] } }
            using (var client = PrepareRequest("orders.json"))
            {
                var req = client.PostAsync(new JsonContent(new { order = order }));;
                response = await req;
                rawBody = await req.ReceiveString();
            }

            try
            {
                ShopifyService.CheckResponseExceptions(response, rawBody);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.True(ex.Errors.Count > 0);
            Assert.True(ex.Errors.Any(error => error.Key.Equals("order")));
            Assert.NotNull(ex.Errors.First(err => err.Key.Equals("order")).Value.First());
            Assert.True(ex.Errors.First(err => err.Key.Equals("order")).Value.Count() > 0);
            Assert.True(ex.Errors.All(err => err.Value.Count() > 0));
        }

        [Fact]
        public async Task Does_Not_Reach_Rate_Limit_With_Retry_Policy()
        {
            bool thrown = false;
            int requestCount = 60;
            IEnumerable<Order>[] list = null;
            var service = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            service.SetExecutionPolicy(new RetryExecutionPolicy());

            try 
            {
                var tasks = Enumerable.Range(0, requestCount).Select(_ => service.ListAsync(new OrderFilter()
                {
                    Limit = 1
                }));
                list = await Task.WhenAll(tasks);
            }
            catch (ShopifyRateLimitException)
            {
                thrown = true;
            }

            Assert.False(thrown);
            Assert.NotNull(list);
            Assert.Equal(requestCount, list.Count());
        }

        [Fact]
        public async Task Does_Not_Reach_Rate_Limit_With_Smart_Retry_Policy()
        {
            bool thrown = false;
            int requestCount = 60;
            IEnumerable<Order>[] list = null;
            var service = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            try 
            {
                var tasks = Enumerable.Range(0, requestCount).Select(_ => service.ListAsync(new OrderFilter()
                {
                    Limit = 1
                }));
                list = await Task.WhenAll(tasks);
            }
            catch (ShopifyRateLimitException)
            {
                thrown = true;
            }

            Assert.False(thrown);
            Assert.NotNull(list);
            Assert.Equal(requestCount, list.Count());   
        }

        [Fact]
        public async Task Catches_Rate_Limit()
        {
            int requestCount = 60;
            var service = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            ShopifyRateLimitException ex = null;

            try 
            {
                var tasks = Enumerable.Range(0, requestCount).Select(_ => service.ListAsync(new OrderFilter()
                {
                    Limit = 1
                }));

                await Task.WhenAll(tasks);
            }
            catch (ShopifyRateLimitException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.Equal(429, (int) ex.HttpStatusCode);
            Assert.NotNull(ex.RawBody);
            Assert.True(ex.Errors.Count > 0);
            Assert.Equal("Error", ex.Errors.First().Key);
            Assert.Equal("Exceeded 2 calls per second for api client. Reduce request rates to resume uninterrupted service.", ex.Errors.First().Value.First());
        }

        [Fact]
        public async Task Catches_Rate_Limit_With_Base_Exception()
        {
            int requestCount = 60;
            var service = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            ShopifyException ex = null;

            try 
            {
                var tasks = Enumerable.Range(0, requestCount).Select(_ => service.ListAsync(new OrderFilter()
                {
                    Limit = 1
                }));

                await Task.WhenAll(tasks);
            }
            catch (ShopifyException e)
            {
                ex = e;
            }

            Assert.NotNull(ex);
            Assert.IsType(typeof(ShopifyRateLimitException), ex);
            Assert.Equal(429, (int) ex.HttpStatusCode);
            Assert.NotNull(ex.RawBody);
            Assert.True(ex.Errors.Count > 0);
            Assert.Equal("Error", ex.Errors.First().Key);
            Assert.Equal("Exceeded 2 calls per second for api client. Reduce request rates to resume uninterrupted service.", ex.Errors.First().Value.First());
        }
    }
}