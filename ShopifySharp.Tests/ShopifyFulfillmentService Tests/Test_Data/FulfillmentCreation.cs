using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class FulfillmentCreation
    {
        /// <summary>
        /// Generates a valid <see cref="ShopifyFulfillment"/> for testing the Fulfillment API.
        /// </summary>
        public static ShopifyFulfillment GenerateFulfillment(bool multipleTrackingNumbers = false, IEnumerable<ShopifyLineItem> items = null)
        {
            ShopifyFulfillment fulfillment;

            if (multipleTrackingNumbers)
            {
                fulfillment = new ShopifyFulfillment()
                {
                    TrackingCompany = "Jack Black's Pack, Stack and Track",
                    TrackingUrls = new string[] 
                    {
                        "https://example.com/da10038ee679f9afc93a785cafdd8d52",
                        "https://example.com/6349a40313ae3c7544331ff9fb44f28c",
                        "https://example.com/ca0b2d7bcccec4b58a94a24fa04101d3"
                    },
                    TrackingNumbers = new string[] 
                    {
                        "da10038ee679f9afc93a785cafdd8d52",
                        "6349a40313ae3c7544331ff9fb44f28c",
                        "ca0b2d7bcccec4b58a94a24fa04101d3"
                    }
                };
            }
            else
            {
                fulfillment = new ShopifyFulfillment()
                {
                    TrackingCompany = "Jack Black's Pack, Stack and Track",
                    TrackingUrl = "https://example.com/123456789",
                    TrackingNumber = "123456789",
                };
            }

            if (items != null)
            {
                fulfillment.LineItems = items;
            }

            return fulfillment;
        }

        /// <summary>
        /// Creates a new order that can be used to test the Fulfillment API.
        /// </summary>
        /// <returns>The new product.</returns>
        public static async Task<ShopifyOrder> CreateOrder()
        {
            var order = OrderCreation.GenerateOrder();
            var service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            return await service.CreateAsync(order);
        }

        /// <summary>
        /// Deletes a product that was used to test the Fulfillment API.
        /// </summary>
        public static async Task DeleteOrder(long id)
        {
            var service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            await service.DeleteAsync(id);
        }
    }
}
