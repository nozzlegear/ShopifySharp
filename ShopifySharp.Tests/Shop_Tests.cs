using System;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Shop")]
    public class Shop_Tests
    {
        private ShopService _Service { get; } = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task Gets_Shops()
        {
            var shop = await _Service.GetAsync();

            Assert.NotNull(shop);
            EmptyAssert.NotNullOrEmpty(shop.Name);
            EmptyAssert.NotNullOrEmpty(shop.PlanDisplayName);
            EmptyAssert.NotNullOrEmpty(shop.MyShopifyDomain);
        }

        [Fact(Skip = "Private applications cannot be uninstalled.")]
        public async Task Uninstalls_Apps()
        {
            bool threw = false;

            try
            {
                await _Service.UninstallAppAsync();
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Uninstalls_Apps)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }
    }
}
