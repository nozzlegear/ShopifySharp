using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "CustomCollection")]
public class CustomCollectionTests : IClassFixture<CustomCollectionTestsFixture>
{
    private CustomCollectionTestsFixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public CustomCollectionTests(CustomCollectionTestsFixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_CustomCollections()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_CustomCollections()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Gets_CustomCollections()
    {
        var collection = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

        Assert.NotNull(collection);
        Assert.True(collection.Id.HasValue);
        Assert.Equal(Fixture.Title, collection.Title);
    }

    [Fact]
    public async Task Deletes_CustomCollections()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_CustomCollections)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }


    [Fact]
    public async Task Creates_CustomCollections()
    {
        var collection = await Fixture.Create();

        Assert.NotNull(collection);
        Assert.True(collection.Id.HasValue);
        Assert.Equal(Fixture.Title, collection.Title);
    }

    [Fact]
    public async Task Updates_CustomCollections()
    {
        string newTitle = "New Title";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.Title = newTitle;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(newTitle, updated.Title);
    }
}

public class CustomCollectionTestsFixture : IAsyncLifetime
{
    public CustomCollectionService Service { get; } = new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<CustomCollection> Created { get; } = new List<CustomCollection>();

    public string Title => "Things";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        // Create one collection for use with count, list, get, etc. tests.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created CustomCollection with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<CustomCollection> Create(bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new CustomCollection()
        {
            Title = Title,
            Published = false
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
