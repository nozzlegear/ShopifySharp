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

        [Fact]
        public async Task Lists_Checkouts()
        {
            var list = await Service.ListAsync();

            Assert.True(list.Count() >= 0);
            if (list.Count() > 0)
            {
                foreach (Checkout ckout in list)
                {
                    Assert.NotNull(ckout.Token);
                    Assert.NotNull(ckout.CartToken);
                    Assert.NotNull(ckout.Email);
                    Assert.True(ckout.LineItems.Count() > 0);
                    foreach (CheckoutLineItem ln in ckout.LineItems)
                    {
                        Assert.NotNull(ln.SKU);
                        Assert.NotNull(ln.ProductId);
                        Assert.NotNull(ln.Price);
                    }
                    Assert.NotNull(ckout.Currency);
                    Assert.NotNull(ckout.Name);
                }
            }
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
