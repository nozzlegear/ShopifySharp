using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyException_Tests
{
    /// <summary>
    /// A test service designed to throw exceptions.
    /// </summary>
    class ShopifyExceptionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyExceptionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyExceptionService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// A method that will throw an exception which looks like { errors: "some error message"}
        /// </summary>
        public async Task ThrowStringException()
        {
            var request = RequestEngine.CreateRequest("api_permissions/current.json", Method.GET);

            //Make request
            await RequestEngine.ExecuteRequestAsync(_RestClient, request);
        }

        /// <summary>
        /// A method that will throw an exception which looks like { errors: { "order" : "some error message" } }
        /// </summary>
        /// <returns></returns>
        public async Task ThrowObjectException()
        {
            var request = RequestEngine.CreateRequest("orders.json", Method.POST);

            //Make request
            await RequestEngine.ExecuteRequestAsync(_RestClient, request);
        }

        /// <summary>
        /// A method that will throw an exception which looks like { errors: { "order" : [ "some error message" ] } }
        /// </summary>
        /// <returns></returns>
        public async Task ThrowArrayException()
        {
            var request = RequestEngine.CreateRequest("orders.json", Method.POST);

            //Creating an order with tax lines on both line items and the order will return an error
            var order = new ShopifyOrder()
            {
                CreatedAt = DateTime.UtcNow,
                LineItems = new List<ShopifyLineItem>()
                {
                    new ShopifyLineItem()
                    {
                        Title = "Click Keyboard",
                        Price = 99.99,
                        Grams = 600,
                        Quantity = 1,
                        TaxLines = new List<ShopifyTaxLine>()
                        {
                            new ShopifyTaxLine()
                            {
                                Price = 1.0,
                                Rate = 0.01,
                                Title = "Keyboard tax"
                            }
                        }
                    }
                },
                TaxLines = new List<ShopifyTaxLine>()
                {
                    new ShopifyTaxLine()
                    {
                        Price = 6.0,
                        Rate = 0.06,
                        Title = "State tax"
                    }
                }
            };

            request.AddJsonBody(new { order });

            //Make request
            await RequestEngine.ExecuteRequestAsync<ShopifyOrder>(_RestClient, request);
        }

    }
}
