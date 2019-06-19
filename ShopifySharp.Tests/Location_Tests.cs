using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Location")]
    public class Location_Tests
    {
        LocationService Service { get; } = new LocationService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Location_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact]
        public async Task Lists_Locations()
        {
            var list = await Service.ListAsync();

            Assert.NotNull(list);
        }

        [Fact]
        public async Task Gets_Locations()
        {
            var list = await Service.ListAsync();

            // Not all shops have a location.
            if (list.Count() > 0)
            {
                long id = list.First().Id.Value;
                var location = await Service.GetAsync(id);

                Assert.NotNull(location.Address1);
                Assert.True(location.Id.HasValue);
                Assert.NotNull(location.City);
                Assert.NotNull(location.Province);
                Assert.NotNull(location.ProvinceCode);
                Assert.NotNull(location.Zip);
                Assert.NotNull(location.Country);
                Assert.NotNull(location.CountryCode);
                Assert.NotNull(location.Active);
            }
        }
    }
}
