using ShopifySharp.Filters;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "InventoryLevel")]
[Collection("InventoryLevel")]
public class InventoryLevelTests(InventoryLevelTestsFixture fixture, ITestOutputHelper testOutputHelper)
    : IClassFixture<InventoryLevelTestsFixture>
{
    private InventoryLevelTestsFixture Fixture { get; } = fixture;

    [Fact]
    public async Task Lists_Items()
    {
        await Fixture.Create();
            
        var list = await Fixture.Service.ListAsync(new InventoryLevelListFilter { InventoryItemIds = new[] { Fixture.InventoryItemId } }, TestContext.Current.CancellationToken);
            
        Assert.NotEmpty(list.Items);
    }

    [Fact]
    public async Task Creates_InventoryLevel()
    {
        var created = await Fixture.Create();
            
        Assert.NotNull(created);
    }

    [Fact(Skip = "Updating an inventory level now requires the inventory item to have tracking enabled")]
    public async Task Updates_InventoryLevel()
    {
        var invLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter
        {
            InventoryItemIds = [Fixture.InventoryItemId]
        }, TestContext.Current.CancellationToken)).Items.First();

        var random = new Random();
        var newQty = invLevel.Available ?? 0;
        var currQty = newQty;
            
        while (newQty == currQty)
        {
            invLevel.Available = newQty = random.Next(5, 55);
        }

        var updated = await Fixture.Service.SetAsync(invLevel, true, TestContext.Current.CancellationToken);

        Assert.Equal(newQty, updated.Available);
        Assert.NotEqual(currQty, updated.Available);
    }

    [Fact(Skip = "This test is flaky and often returns an error with an empty body")]
    public async Task Adjust_InventoryLevel()
    {
        var availableAdjustment = 1;
        var invLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter
        {
            InventoryItemIds = new long[] { Fixture.InventoryItemId }
        }, TestContext.Current.CancellationToken)).Items.First();

        var adjustInventoryLevel = new InventoryLevelAdjust()
        {
            AvailableAdjustment = availableAdjustment,
            InventoryItemId = invLevel.InventoryItemId,
            LocationId = invLevel.LocationId
        };

        long newQty, currQty;
        currQty = invLevel.Available ?? 0;
        newQty = currQty + availableAdjustment;

        var updated = await Fixture.Service.AdjustAsync(adjustInventoryLevel, TestContext.Current.CancellationToken);

        Assert.Equal(newQty, updated.Available);
        Assert.NotEqual(currQty, updated.Available);
    }

    [Fact(Skip = "Test appears to be broken in mysterious ways, with Shopify returning a 500 internal server error")]
    public async Task Deletes_InventoryLevel()
    {
        var currentInvLevel = (await Fixture.Service.ListAsync(new InventoryLevelListFilter 
        { 
            InventoryItemIds = new[] 
            { 
                Fixture.InventoryItemId 
            } 
        }, TestContext.Current.CancellationToken)).Items.First();

        // Create a new inventory level
        var created = await Fixture.Create(true);
            
        //When switching from the default location to a Fulfillment location, the default InventoryLevel is deleted
        //Set inventory back to original location because a location is required
        await Fixture.Service.SetAsync(currentInvLevel, true, TestContext.Current.CancellationToken);

        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.InventoryItemId.Value, created.LocationId.Value, TestContext.Current.CancellationToken);
        }
        catch (ShopifyException ex)
        {
            testOutputHelper.WriteLine($"{nameof(Deletes_InventoryLevel)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);

        //Delete will not throw an error but still will not delete if there isn't another location available for the product.
        Assert.Empty((await Fixture.Service.ListAsync(new InventoryLevelListFilter
        {
            InventoryItemIds = new[]
            {
                created.InventoryItemId.Value
            },
            LocationIds = new[]
            {
                created.LocationId.Value
            }
        }, TestContext.Current.CancellationToken)).Items);
    }
}

public class InventoryLevelTestsFixture : IAsyncLifetime
{
    public readonly InventoryLevelService Service = new InventoryLevelService(Utils.MyShopifyUrl, Utils.AccessToken);

    public readonly ProductService ProductService = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

    public readonly ProductVariantService VariantService = new ProductVariantService(Utils.MyShopifyUrl, Utils.AccessToken);

    public readonly InventoryItemService InventoryItemService = new InventoryItemService(Utils.MyShopifyUrl, Utils.AccessToken);

    public long LocationId => 6226758;

    public long InventoryItemId { get; private set; }

    public long VariantId { get; private set; }

    public long ProductId { get; private set; }

    public List<InventoryLevel> Created { get; } = new List<InventoryLevel>();

    public async System.Threading.Tasks.ValueTask InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        ProductService.SetExecutionPolicy(policy);
        VariantService.SetExecutionPolicy(policy);
        InventoryItemService.SetExecutionPolicy(policy);

        // Create a product to use with these tests.
        var product = await CreateProductAndVariantAsync();
        ProductId = product.Id.Value;

        // Get the product's variant and use its inventory item id for tests
        var variant = product.Variants.First();
        VariantId = variant.Id.Value;
        InventoryItemId = variant.InventoryItemId.Value;

        // Set an SKU and inventory management policy on the variant. This is required for fulfillment.
        variant.SKU = "TestSKU";
        variant.InventoryManagement = "shopify";
        // InventoryQuantity must be null as it is read-only
        variant.InventoryQuantity = null;

        await VariantService.UpdateAsync(VariantId, variant);

        // Enable inventory tracking on the inventory item. Required for AdjustAsync/SetAsync.
        var inventoryItem = await InventoryItemService.GetAsync(InventoryItemId);
        if (inventoryItem.Tracked == false)
        {
            inventoryItem.Tracked = true;
            await InventoryItemService.UpdateAsync(InventoryItemId, inventoryItem);
        }
    }

    public async ValueTask DisposeAsync()
    {
        try
        {
            await ProductService.DeleteAsync(ProductId);
        }
        catch (ShopifyException ex)
        {
            Console.WriteLine($"Failed to delete product with id {ProductId}. {ex.Message}");
        }

        foreach (var created in Created)
        {
            try
            {
                await Service.DeleteAsync(created.InventoryItemId.Value, created.LocationId.Value);
            }
            catch (ShopifyHttpException ex) when ((int) ex.HttpStatusCode == 406)
            {
                // The last inventory level for an item cannot be deleted. In this case, Shopify will return a 406.
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"Failed to delete inventory level with item id {created.InventoryItemId} and location id {created.LocationId}. {ex.Message}");
                throw;
            }
        }
    }

    private Task<Product> CreateProductAndVariantAsync()
    {
        return ProductService.CreateAsync(new Product()
        {
            Title = "ShopifySharp Test Product",
            Vendor = "Auntie Dot",
            BodyHtml = "<strong>This product was created while testing ShopifySharp!</strong>",
            ProductType = "Foobars",
            Handle = Guid.NewGuid().ToString(),
            Images = new List<ProductImage>
            {
                new ProductImage
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
                }
            },
        });
    }

    public async Task<InventoryLevel> Create(bool skipAddToCreated = false)
    {
        var created = await Service.ConnectAsync(InventoryItemId, LocationId);

        if (!skipAddToCreated)
        {
            Created.Add(created);
        }

        return created;
    }
}
