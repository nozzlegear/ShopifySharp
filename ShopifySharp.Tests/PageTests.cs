using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "Page")]
public class PageTests : IClassFixture<PageTestsFixture>
{
    private PageTestsFixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public PageTests(PageTestsFixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_Pages()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_Pages()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Deletes_Pages()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Pages)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_Pages()
    {
        var page = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

        Assert.NotNull(page);
        Assert.Equal(Fixture.Title, page.Title);
        Assert.Equal(Fixture.Html, page.BodyHtml);
    }

    [Fact]
    public async Task Creates_Pages()
    {
        var created = await Fixture.Create();

        Assert.NotNull(created);
        Assert.Equal(Fixture.Title, created.Title);
        Assert.Equal(Fixture.Html, created.BodyHtml);
    }

    [Fact]
    public async Task Updates_Pages()
    {
        string html = "<h1>This string was updated while testing ShopifySharp!</h1>";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.BodyHtml = html;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(html, updated.BodyHtml);
    }
}

public class PageTestsFixture : IAsyncLifetime
{
    public PageService Service { get; } = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Page> Created { get; } = new List<Page>();

    public string Title => "ShopifySharp Page API Tests";

    public string Html => "<strong>This string was created by ShopifySharp!</strong>";

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
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Page with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Page> Create(bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new ShopifySharp.Page()
        {
            CreatedAt = DateTime.UtcNow,
            Title = Title,
            BodyHtml = Html,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
