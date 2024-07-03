using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "InventoryItem")]
public class InventoryItem_Tests : IClassFixture<InventoryItem_Tests_Fixture>
{
    private InventoryItem_Tests_Fixture Fixture { get; }

    public InventoryItem_Tests(InventoryItem_Tests_Fixture fixture)
    {
        this.Fixture = fixture;
    }

    [Fact]
    public async Task Lists_Items()
    {
        var list = await Fixture.Service.ListAsync(new InventoryItemListFilter { Ids = new[] { Fixture.Created.First().InventoryItemId.Value } });
        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Gets_Item()
    {
        var created = await Fixture.Service.GetAsync(Fixture.Created.First().InventoryItemId.Value);
        Assert.NotNull(created);
        Assert.True(created.Id.HasValue);
    }

    [Fact]
    public async Task Updates_Item()
    {
        var created = await Fixture.Service.GetAsync(Fixture.Created.First().InventoryItemId.Value);
        long id = created.Id.Value;
        string sku = "Some Updated sku";
        decimal cost = 42.42m;

        created.SKU = sku;
        created.Cost = cost;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        Assert.Equal(sku, updated.SKU);
        Assert.Equal(cost, updated.Cost);
    }
}

public class InventoryItem_Tests_Fixture : IAsyncLifetime
{
    public InventoryItemService Service { get; } = new InventoryItemService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ProductVariantService VariantService { get; } = new ProductVariantService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<ProductVariant> Created { get; } = new List<ProductVariant>();

    public decimal Price => 123.45m;

    public long ProductId { get; set; }

    public async Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        ProductService.SetExecutionPolicy(policy);
        VariantService.SetExecutionPolicy(policy);

        // Get a product id to use with these tests.
        ProductId = (await ProductService.ListAsync(new ProductListFilter()
        {
            Limit = 1
        })).Items.First().Id.Value;

        // Create one for use with count, list, get, etc. tests.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            if (!obj.Id.HasValue)
            {
                continue;
            }

            try
            {
                await VariantService.DeleteAsync(ProductId, obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
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

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
