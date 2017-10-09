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

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Checkouts()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }
    }
}
