using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Checkout")]
    public class Checkout_Tests
    {
        CheckoutService Service { get; } = new CheckoutService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Checkout_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Creates_Checkouts()
        {
            var checkout = await Service.CreateAsync(new Checkout
            {
                Email = "joshua@nozzlegear.com"
            });

            Assert.NotNull(checkout);
            Assert.Equal("joshua@nozzlegear.com", checkout.Email);
        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Completes_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Gets_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Updates_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Lists_Checkout_Shipping_Rates()
        {

        }
    }
}
