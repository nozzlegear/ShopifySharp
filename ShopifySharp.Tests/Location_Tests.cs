using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Location")]
public class Location_Tests
{
    LocationService Service { get; } = new LocationService(Utils.MyShopifyUrl, Utils.AccessToken);

    public Location_Tests()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
    }

    [Fact(Skip = "read_locations scope is required as of 2024-10")]
    public async Task Lists_Locations()
    {
        var list = await Service.ListAsync();

        Assert.NotNull(list);
    }

    [Fact(Skip = "read_locations scope is required as of 2024-10")]
    public async Task Gets_Locations()
    {
        var list = await Service.ListAsync();

        // Not all shops have a location.
        if (list.Items.Count() > 0)
        {
            long id = list.Items.First().Id.Value;
            var location = await Service.GetAsync(id);

            Assert.NotNull(location.Address1);
            Assert.True(location.Id.HasValue);
            Assert.NotNull(location.City);
            Assert.NotNull(location.Zip);
            Assert.NotNull(location.Country);
            Assert.NotNull(location.CountryCode);
            Assert.NotNull(location.Active);
        }
    }
}