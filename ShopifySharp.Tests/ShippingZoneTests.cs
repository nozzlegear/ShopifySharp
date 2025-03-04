using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "ShippingZone")]
public class ShippingZoneTests
{
    ShippingZoneService Service { get; } = new ShippingZoneService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ShippingZoneTests()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
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