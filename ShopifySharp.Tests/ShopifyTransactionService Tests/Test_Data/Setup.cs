using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyTransactionService_Tests
{
    public static class Setup
    {
        /// <summary>
        /// Generates a valid <see cref="ShopifyTransaction"/> for testing the Transaction API.
        /// </summary>
        public static ShopifyTransaction GenerateTransaction(string kind = "authorization", double? amount = null)
        {
            return new ShopifyTransaction()
            {
                Amount = amount ?? null,
                Currency = "USD",
                Test = true,
                Gateway = "bogus",
                Kind = kind,
                Status = "success"
            };
        }

        /// <summary>
        /// Creates a new order that can be used to test the Transaction API.
        /// </summary>
        /// <returns>The new product.</returns>
        public static async Task<ShopifyOrder> CreateOrder()
        {
            var order = Test_Data.OrderCreation.GenerateOrder();
            var service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            return await service.CreateAsync(order);
        }

        /// <summary>
        /// Deletes a product that was used to test the Transaction API.
        /// </summary>
        public static async Task DeleteOrder(long id)
        {
            var service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            await service.DeleteAsync(id);
        }
    }
}
