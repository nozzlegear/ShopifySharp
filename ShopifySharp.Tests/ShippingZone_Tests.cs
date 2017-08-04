using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ShippingZone")]
    public class ShippingZone_Tests
    {
        private ShippingZoneService _Service => new ShippingZoneService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task Lists_ShippingZones()
        {
            var list = await _Service.ListAsync();

            Assert.NotNull(list);
        }
    }
}