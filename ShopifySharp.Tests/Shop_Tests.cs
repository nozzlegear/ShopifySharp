using System;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Shop")]
    public class Shop_Tests
    {
        ShopService Service { get; } = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Shop_Tests()
        {
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
        }

        [Fact]
        public async Task Gets_Shops()
        {
            var shop = await Service.GetAsync();

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
                await Service.UninstallAppAsync();
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
