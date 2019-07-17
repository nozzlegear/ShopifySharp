using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "InventoryLevel")]
    public class InventoryLevel_Tests : IClassFixture<InventoryLevel_Tests_Fixture>
    {
        private InventoryLevel_Tests_Fixture Fixture { get; }

        public InventoryLevel_Tests(InventoryLevel_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Lists_Items()
        {
            var list = await Fixture.Service.ListAsync(new InventoryLevelFilter { InventoryItemIds = new[] { Fixture.Created.First().InventoryItemId.Value } });
            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Sets_Level()
        {
            var variant = await Fixture.Create();
            var inventoryItem = await Fixture.InventoryItemService.GetAsync(variant.InventoryItemId.Value);
            var inventoryLevels = await Fixture.Service.ListAsync(new InventoryLevelFilter() { InventoryItemIds = new long[] { inventoryItem.Id.Value } });
            var inventoryLevel = inventoryLevels.First();

            inventoryLevel.Available++;

            bool threw = false;

            try
            {
                await Fixture.Service.SetAsync(inventoryLevel);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Sets_Level)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }
    }

    public class InventoryLevel_Tests_Fixture : IAsyncLifetime
    {
        public InventoryLevelService Service { get; } = new InventoryLevelService(Utils.MyShopifyUrl, Utils.AccessToken);

        public InventoryItemService InventoryItemService { get; } = new InventoryItemService(Utils.MyShopifyUrl, Utils.AccessToken);

        public ProductVariantService VariantService { get; } = new ProductVariantService(Utils.MyShopifyUrl, Utils.AccessToken);        

        public List<ProductVariant> Created { get; } = new List<ProductVariant>();

        public decimal Price => 123.45m;

        public long ProductId { get; set; }

        public async Task InitializeAsync()
        {
            // Get a product id to use with these tests.
            ProductId = (await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync(new ProductFilter()
            {
                Limit = 1
            })).First().Id.Value;

            // Create one for use with count, list, get, etc. tests.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                if (! obj.Id.HasValue) 
                {
                    continue; 
                }

                try
                {
                    await VariantService.DeleteAsync(ProductId, obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created ProductVariant with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<ProductVariant> Create(string option1 = null, bool skipAddToCreatedList = false)
        {
            var obj = await VariantService.CreateAsync(ProductId, new ProductVariant()
            {
                Option1 = Guid.NewGuid().ToString(),
                Price = Price,
                InventoryManagement = "shopify",
                SKU = "Some sku"
            });

            if (! skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
