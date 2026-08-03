using System.Net;
using ShopifySharp.Filters;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "SmartCollection")]
[Collection("SmartCollection")]
public class SmartCollectionTests(SmartCollectionTestsFixture fixture) : IClassFixture<SmartCollectionTestsFixture>
{
    private SmartCollectionTestsFixture Fixture { get; } = fixture;

    [Fact]
    public async Task Counts_SmartCollections()
    {
        // Act
        var count = await Fixture.Service.CountAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        count.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task Lists_SmartCollections()
    {
        // Act
        var list = await Fixture.Service.ListAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        list.Items.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Deletes_SmartCollections()
    {
        // Setup
        var created = await Fixture.Create(true, true);

        // Act
        var act = async () => await Fixture.Service.DeleteAsync(created.Id!.Value, TestContext.Current.CancellationToken);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task Gets_SmartCollections()
    {
        // Setup
        var created = await Fixture.Create();

        // Act
        var obj = await Fixture.Service.GetAsync(created.Id!.Value, TestContext.Current.CancellationToken);

        // Assert
        obj.Should().NotBeNull();
        obj.Id.Should().HaveValue().And.Be(created.Id);
        obj.BodyHtml.Should().Be(SmartCollectionTestsFixture.BodyHtml);
        obj.Title.Should().Be(SmartCollectionTestsFixture.Title);
        obj.Handle.Should().StartWithEquivalentOf(SmartCollectionTestsFixture.HandlePrefix, x => x.IgnoringCase());
    }

    [Fact]
    public async Task Creates_SmartCollections()
    {
        // Act
        var obj = await Fixture.Create();

        // Assert
        obj.Should().NotBeNull();
        obj.Id.Should().HaveValue().And.BeGreaterThan(0);
        obj.BodyHtml.Should().Be(SmartCollectionTestsFixture.BodyHtml);
        obj.Title.Should().Be(SmartCollectionTestsFixture.Title);
        obj.Handle.Should().StartWithEquivalentOf(SmartCollectionTestsFixture.HandlePrefix, x => x.IgnoringCase());
        obj.PublishedAt.Should().NotBeNull();
        obj.PublishedScope.Should().NotBeNull();
    }

    [Fact]
    public async Task Creates_Unpublished_SmartCollections()
    {
        // Act
        var obj = await Fixture.Create(false);

        // Assert
        obj.PublishedAt.Should().BeNull();
        obj.PublishedScope.Should().Be("web");
    }

    [Fact]
    public async Task Updates_SmartCollections()
    {
        // Setup
        const string newValue = "New Title";
        var created = await Fixture.Create();
        var id = created.Id!.Value;

        created.Title = newValue;
        created.Id = null;

        // Act
        var updated = await Fixture.Service.UpdateAsync(id, created, TestContext.Current.CancellationToken);
        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        // Assert
        updated.Title.Should().Be(newValue);
    }

    [Fact]
    public async Task Publishes_SmartCollections()
    {
        // Setup
        var created = await Fixture.Create(false);

        // Act
        var updated = await Fixture.Service.PublishAsync(created.Id!.Value, TestContext.Current.CancellationToken);

        // Assert
        updated.PublishedAt.Should().NotBeNull();
        created.PublishedAt.Should().BeNull("collection should have been created in an unpublished state");
    }

    [Fact]
    public async Task Unpublishes_SmartCollections()
    {
        // Setup
        var created = await Fixture.Create();

        // Act
        var updated = await Fixture.Service.UnpublishAsync(created.Id!.Value, TestContext.Current.CancellationToken);

        // Assert
        updated.PublishedAt.Should().BeNull();
        created.PublishedAt.Should().NotBeNull("collection should have been created in a published state");
    }

    [Fact(Skip = "This test has a bit of a time delay that ShopifySharp isn't equipped to handle yet (Retry-After header).")]
    public async Task Updates_SmartCollection_Products_Order()
    {
        //generate a unique tag
        var tag = Guid.NewGuid().ToString();

        //create collection
        var collection = await Fixture.Service.CreateAsync(new SmartCollection
        {
            BodyHtml = SmartCollectionTestsFixture.BodyHtml,
            Handle = SmartCollectionTestsFixture.HandlePrefix,
            Title = SmartCollectionTestsFixture.Title,
            Rules = new List<SmartCollectionRules>
            {
                new()
                {
                    Column = "tag",
                    Condition = tag,
                    Relation = "equals"
                }
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        //create 4 products with unique tag
        var products = new List<Product>();
        for (var i = 0; i < 4; i++)
        {
            var product = await Fixture.ProductService.CreateAsync(new Product()
            {
                Title = Guid.NewGuid().ToString(),
                Tags = tag
            }, cancellationToken: TestContext.Current.CancellationToken);
            products.Add(product);
        }

        //reorder items
        products.Reverse();
        var productIds = products.Select(p => p.Id!.Value).ToArray();
        await Fixture.Service.UpdateProductOrderAsync(collection.Id!.Value, "manual", productIds);


        //get collection
        collection = await Fixture.Service.GetAsync(collection.Id.Value, TestContext.Current.CancellationToken);

        //get products  - use collect service to get products so they are returned in order
        var collects = (await Fixture.CollectService.ListAsync(new CollectListFilter { CollectionId = collection.Id }, TestContext.Current.CancellationToken)).Items.ToList();

        // Assert
        Assert.Equal("manual", collection.SortOrder);
        collects.ForEach(c => Assert.Contains(c.ProductId!.Value, productIds));

        // Delete the objects
        await Fixture.Service.DeleteAsync(collection.Id!.Value, TestContext.Current.CancellationToken);

        foreach (var product in products)
        {
            await Fixture.ProductService.DeleteAsync(product.Id!.Value, TestContext.Current.CancellationToken);
        }
    }
}

public class SmartCollectionTestsFixture : IAsyncLifetime
{
    public readonly SmartCollectionService Service = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public readonly ProductService ProductService = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public readonly CollectService CollectService = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<SmartCollection> Created { get; } = [];

    public static string BodyHtml => "<h1>Hello world!</h1>";

    public static string HandlePrefix => "shopifysharp-handle-";

    public static string Title => "ShopifySharp Test Smart Collection";

    public async ValueTask InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        ProductService.SetExecutionPolicy(policy);
        CollectService.SetExecutionPolicy(policy);

        // Create one collection for use with count, list, get, etc. tests.
        await Create();
    }

    public async ValueTask DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.Id!.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created SmartCollection with id {obj.Id!.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<SmartCollection> Create(bool published = true, bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new SmartCollection()
        {
            BodyHtml = BodyHtml,
            Handle = HandlePrefix + Guid.NewGuid(),
            Title = Title,
            Rules = new List<SmartCollectionRules>
            {
                new()
                {
                    Column = "variant_price",
                    Condition = "20",
                    Relation = "less_than"
                }
            }
        }, published);

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
