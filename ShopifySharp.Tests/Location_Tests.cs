using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests.ShopifyLocationService_Tests
{
    [Trait("Category", "Location")]
    public class Location_Tests
    {
        private LocationService _Service => new LocationService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task Lists_Locations()
        {
            var list = await _Service.ListAsync();

            Assert.NotNull(list);
        }

        [Fact]
        public async Task Gets_Locations()
        {
            var list = await _Service.ListAsync();

            // Not all shops have a location.
            if (list.Count() > 0)
            {
                long id = list.First().Id.Value;
                var location = await _Service.GetAsync(id);

                Assert.NotNull(location.Address1);
                Assert.True(location.Id.HasValue);
                Assert.NotNull(location.City);
                Assert.NotNull(location.Province);
                Assert.NotNull(location.Zip);
                Assert.NotNull(location.Country);
            }
        }
    }
}
