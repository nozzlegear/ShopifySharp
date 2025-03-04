using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Collection")]
public class CollectionTests : IClassFixture<CollectionTestsFixture>
{
    private CollectionTestsFixture Fixture { get; }

    public CollectionTests(CollectionTestsFixture fixture)
    {
        this.Fixture = fixture;
    }
        
    [Fact]
    public async Task Gets_Collects()
    {
        var collect = await this.Fixture.Service.GetAsync(this.Fixture.CollectionId);
            
        Assert.NotNull(collect);
        Assert.Equal("Things", collect.Title);
        Assert.Null(collect.PublishedAt);
        Assert.NotNull(collect.UpdatedAt);
        Assert.Equal("<h1>Hello from ShopifySharp</h1>", collect.BodyHtml);
        Assert.NotNull(collect.Image);
        Assert.NotEmpty(collect.Image.Src);
    }

    [Fact]
    public async Task Lists_Products_Belonging_To_Collection()
    {
        var products = await this.Fixture.Service.ListProductsAsync(this.Fixture.CollectionId);
            
        Assert.NotNull(products);
        Assert.False(products.HasNextPage);
        Assert.False(products.HasPreviousPage);
        Assert.NotEmpty(products.Items);
        Assert.Single(products.Items);

        var product = products.Items.First();

        Assert.NotNull(product.CreatedAt);
        Assert.Equal( "Burton Custom Freestlye 151",product.Title);
        Assert.Equal( "Burton",product.Vendor);
        Assert.Equal( "<strong>Good snowboard!</strong>",product.BodyHtml);
        Assert.Equal( "Snowboard",product.ProductType);
        Assert.NotEmpty(product.Handle);
        Assert.NotEmpty(product.Images);
        Assert.NotNull(product.PublishedAt);
    }
}
    
public class CollectionTestsFixture : IAsyncLifetime
{
    public CollectionService Service { get; } = new CollectionService(Utils.MyShopifyUrl, Utils.AccessToken);
        
    public CollectService CollectService { get; } = new CollectService(Utils.MyShopifyUrl, Utils.AccessToken);

    public CustomCollectionService CustomCollectionService { get; } = new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Collect> Created { get; } = new List<Collect>();

    /// <remarks>
    /// Hardcoded collection id used in previous versions was 27369427.
    /// </remarks>
    public long CollectionId { get; set; }

    public async Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        CollectService.SetExecutionPolicy(policy);
        ProductService.SetExecutionPolicy(policy);
        CustomCollectionService.SetExecutionPolicy(policy);

        // Create a custom collection to use with these tests.
        var collection = await CustomCollectionService.CreateAsync(new CustomCollection()
        {
            Title = "Things",
            Published = false,
            BodyHtml = "<h1>Hello from ShopifySharp</h1>",
            Image = new CustomCollectionImage()
            {
                Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
            }
        });

        CollectionId = collection.Id.Value;

        // Create a collection to use with get, list, count, etc. tests.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await CollectService.DeleteAsync(obj.Id.Value);
                await ProductService.DeleteAsync(obj.ProductId.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Collect with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }

        // Delete the collection
        if (CollectionId != 0)
        {
            await CustomCollectionService.DeleteAsync(CollectionId);
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Collect> Create(bool skipAddToCreatedList = false)
    {
        // Create a product to use with these tests.
        var product = await ProductService.CreateAsync(new ShopifySharp.Product()
        {
            CreatedAt = DateTime.UtcNow,
            Title = "Burton Custom Freestlye 151",
            Vendor = "Burton",
            BodyHtml = "<strong>Good snowboard!</strong>",
            ProductType = "Snowboard",
            Handle = Guid.NewGuid().ToString(),
            Images = new List<ProductImage> { new ProductImage { Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" } },
            PublishedScope = "published"
        });
        var obj = await CollectService.CreateAsync(new Collect()
        {
            CollectionId = CollectionId,
            ProductId = product.Id.Value,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
