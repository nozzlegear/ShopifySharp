using System;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{

    /// <remarks>
    /// For the tests below to pass, the required permissions must be granted AND Shopify payments must be set as a payment provider in the store's settings
    /// </remarks>
    [Trait("Category", "Shopify payments")]
    public class ShopifyPayments_Tests
    {
        ShopifyPaymentsService Service { get; } = new ShopifyPaymentsService(Utils.MyShopifyUrl, Utils.AccessToken);

        public ShopifyPayments_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact]
        public async Task GetBalance()
        {
            if (await Service.IsShopifyPaymentAPIEnabledAsync())
            {
                var balances = await Service.GetBalanceAsync();
                Assert.NotNull(balances);
            }
        }

        [Fact]
        public async Task GetPayouts()
        {
            if (await Service.IsShopifyPaymentAPIEnabledAsync())
            {
                var payouts = await Service.ListPayoutsAsync();
                Assert.NotNull(payouts);
            }
        }

        [Fact]
        public async Task GetDisputes()
        {
            if (await Service.IsShopifyPaymentAPIEnabledAsync())
            {
                var disputes = await Service.ListDisputesAsync();
                Assert.NotNull(disputes);
            }
        }

        [Fact]
        public async Task GetTransactions()
        {
            if (await Service.IsShopifyPaymentAPIEnabledAsync())
            {
                var transactions = await Service.ListTransactionsAsync();
                Assert.NotNull(transactions);
            }
        }
    }
}
