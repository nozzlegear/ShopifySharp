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
        ShippingZoneService Service { get; } = new ShippingZoneService(Utils.MyShopifyUrl, Utils.AccessToken);

        public ShippingZone_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact]
        public async Task Lists_ShippingZones()
        {
            var shippingZones = await Service.ListAsync();

            Assert.NotNull(shippingZones);

            foreach (var shippingZone in shippingZones)
            {
                Assert.NotNull(shippingZone.Name);
            }
        }
    }
}