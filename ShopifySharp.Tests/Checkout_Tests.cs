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

        private CheckoutService _Service { get; } = new CheckoutService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task Counts_Checkouts()
        {
            var count = await _Service.CountAsync();

            Assert.True(count >= 0);
        }

        [Fact]
        public async Task Lists_Checkouts()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() >= 0);
            if (list.Count() > 0)
            { 
                foreach(Checkout ckout in list)
                {
                    Assert.NotNull(ckout.Token);
                    Assert.NotNull(ckout.CartToken);
                    Assert.NotNull(ckout.Email);
                    Assert.True(ckout.LineItems.Count() > 0);
                    foreach(CheckoutLineItem ln in ckout.LineItems)
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
    }
}
