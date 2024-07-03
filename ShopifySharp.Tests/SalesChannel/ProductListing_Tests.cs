using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "ProductListing")]
public class ProductListing_Tests : IClassFixture<ProductListing_Tests_Fixture>
{
    private ProductListing_Tests_Fixture Fixture { get; }

    public ProductListing_Tests(ProductListing_Tests_Fixture fixture)
    {
        this.Fixture = fixture;
    }
        
    [Fact(Skip = "Sales channel tests cannot be run with ShopifySharp's private/custom app.")]
    public async Task Counts_Products()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact(Skip = "Sales channel tests cannot be run with ShopifySharp's private/custom app.")]
    public async Task Lists_Products_NoFilter()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Any());
        if (list.LinkHeader != null)
        {
            Assert.NotNull(list.LinkHeader.NextLink);
            Assert.NotNull(list.LinkHeader.NextLink.PageInfo);
            Assert.NotNull(list.LinkHeader.NextLink.Url);
        }
    }
}

public class ProductListing_Tests_Fixture : IAsyncLifetime
{
    public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
    public ProductListingService Service { get; } = new ProductListingService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Product> Created { get; } = new List<Product>();

    public string Title => "ShopifySharp Test Product";

    public string Vendor = "Auntie Dot";

    public string BodyHtml => "<strong>This product was created while testing ShopifySharp!</strong>";

    public string ProductType => "Foobars";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            
        // Create one for count, list, get, etc. orders.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.Id.Value);
                await ProductService.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Product with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Product> Create(bool skipAddToCreateList = false, ProductCreateOptions options = null)
    {
        var obj = await ProductService.CreateAsync(new Product()
        {
            Title = Title,
            Vendor = Vendor,
            BodyHtml = BodyHtml,
            ProductType = ProductType,
            Handle = Guid.NewGuid().ToString(),
            Images = new List<ProductImage>
            {
                new ProductImage
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
                }
            },
        }, options);

        if (!skipAddToCreateList)
        {
            Created.Add(obj);
        }

        var productListing = await Service.CreateAsync(obj.Id.Value);

        return obj;
    }
}
