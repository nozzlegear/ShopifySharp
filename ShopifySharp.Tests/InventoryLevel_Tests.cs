using ShopifySharp.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

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
            var list = await Fixture.Service.ListAsync(new InventoryLevelListFilter { InventoryItemIds = new[] { Fixture.InventoryItemId } });
            Assert.True(list.Items.Count() > 0);
        }

        [Fact]
        public async Task Creates_InventoryLevel()
        {
            var created = await Fixture.Create();
            Assert.NotNull(created);
        }

        [Fact]
        public async Task Updates_InventoryLevel()
        {
            var invLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter
            {
                InventoryItemIds = new long[] { Fixture.InventoryItemId }
            })).Items.First();

            Random newRandom = new Random();
            int newQty, currQty;
            newQty = currQty = invLevel.Available ?? 0;
            while (newQty == currQty)
            {
                invLevel.Available = newQty = newRandom.Next(5, 55);
            }

            var updated = await Fixture.Service.SetAsync(invLevel, true);

            Assert.Equal(newQty, updated.Available);
            Assert.NotEqual(currQty, updated.Available);
        }

        [Fact]
        public async Task Adjust_InventoryLevel()
        {
            var availableAdjustment = 1;
            var invLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter
            {
                InventoryItemIds = new long[] { Fixture.InventoryItemId }
            })).Items.First();

            var adjustInventoryLevel = new InventoryLevelAdjust()
            {
                AvailableAdjustment = availableAdjustment,
                InventoryItemId = invLevel.InventoryItemId,
                LocationId = invLevel.LocationId
            };

            int newQty, currQty;
            currQty = invLevel.Available ?? 0;
            newQty = currQty + availableAdjustment;

            var updated = await Fixture.Service.AdjustAsync(adjustInventoryLevel);

            Assert.Equal(newQty, updated.Available);
            Assert.NotEqual(currQty, updated.Available);
        }

        [Fact(Skip = "Test appears to be broken in mysterious ways, with Shopify returning a 500 internal server error")]
        public async Task Deletes_InventoryLevel()
        {
            var currentInvLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter { InventoryItemIds = new[] { Fixture.InventoryItemId } })).Items.First();
            //When switching from the default location to a Fulfillment location, the default InventoryLevel is deleted
            var created = await Fixture.Create();
            //Set inventory back to original location because a location is required
            await Fixture.Service.SetAsync(currentInvLevel, true);
            bool threw = false;
            try
            {
                await Fixture.Service.DeleteAsync(created.InventoryItemId.Value, created.LocationId.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_InventoryLevel)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
            //Delete will not throw an error but still will not delete if there isn't another location available for the product.
            Assert.Equal(0, (await Fixture.Service.ListAsync(new InventoryLevelListFilter { InventoryItemIds = new[] { created.InventoryItemId.Value }, LocationIds = new[] { created.LocationId.Value } })).Items.Count());
        }
    }

    public class InventoryLevel_Tests_Fixture : IAsyncLifetime
    {
        public InventoryLevelService Service { get; } = new InventoryLevelService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Product_Tests_Fixture ProductTest { get; } = new Product_Tests_Fixture();

        public ProductVariant_Tests_Fixture VariantTest { get; } = new ProductVariant_Tests_Fixture();

        public FulfillmentService_Tests_Fixture FulfillmentServiceServTest { get; } = new FulfillmentService_Tests_Fixture();

        public long InventoryItemId { get; set; }

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Get a product id to use with these tests.
            var prod = await ProductTest.Create();
            VariantTest.ProductId = prod.Id.Value;
            var variant = prod.Variants.First();
            InventoryItemId = variant.InventoryItemId.Value;
            variant.SKU = "TestSKU";//To change fulfillment, SKU is required
            variant.InventoryManagement = "Shopify";//To set inventory, InventoryManagement must be Shopify

            await VariantTest.Service.UpdateAsync(variant.Id.Value, variant);
        }

        public async Task DisposeAsync()
        {
            await VariantTest.DisposeAsync();
            await ProductTest.DisposeAsync();
            await FulfillmentServiceServTest.DisposeAsync();
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<InventoryLevel> Create(bool skipAddToCreateList = false)
        {
            var locId = (await FulfillmentServiceServTest.Create(skipAddToCreateList)).LocationId.Value;
            return await Service.ConnectAsync(InventoryItemId, locId, true);
        }
    }
}