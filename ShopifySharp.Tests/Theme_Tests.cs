using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "Theme")]
public class Theme_Tests : IClassFixture<Theme_Tests_Fixture>
{
    private Theme_Tests_Fixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public Theme_Tests(Theme_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Lists_Themes()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Count() > 0);
    }

    [Fact(Skip = "Often fails during CI tests because stores can only have 20 themes.")]
    public async Task Deletes_Themes()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Themes)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact(Skip = "Often fails during CI tests because stores can only have 20 themes.")]
    public async Task Gets_Themes()
    {
        var created = await Fixture.Create();
        var obj = await Fixture.Service.GetAsync(created.Id.Value);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.StartsWith(Fixture.NamePrefix, obj.Name);
        Assert.Equal(Fixture.Role, obj.Role);
    }

    [Fact(Skip = "Often fails during CI tests because stores can only have 20 themes.")]
    public async Task Creates_Themes()
    {
        var obj = await Fixture.Create();

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.StartsWith(Fixture.NamePrefix, obj.Name);
        Assert.Equal(Fixture.Role, obj.Role);
    }

    [Fact(Skip = "Often fails during CI tests because stores can only have 20 themes.")]
    public async Task Creates_Themes_From_Zip_Files()
    {
        var obj = await Fixture.Create(fromZipUrl: true);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.StartsWith(Fixture.NamePrefix, obj.Name);
        Assert.Equal(Fixture.Role, obj.Role);
    }

    [Fact(Skip = "Often fails during CI tests because stores can only have 20 themes.")]
    public async Task Updates_Themes()
    {
        string newValue = ("ShopifySharp Updated Theme " + Guid.NewGuid()).Substring(0, 50);
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.Name = newValue;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(newValue, updated.Name);
    }
}

public class Theme_Tests_Fixture : IAsyncLifetime
{
    public ThemeService Service { get; } = new ThemeService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Theme> Created { get; } = new List<Theme>();

    /// <summary>
    /// A URL pointing to a zipped up Shopify theme.
    /// </summary>
    public string ZipUrl => "https://ironstorage.blob.core.windows.net/public-downloads/ShopifySharp/shopify_test_theme_for_shopifysharp.zip";

    public string NamePrefix => "ShopifySharp Test Theme ";

    public string Role => "unpublished";

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
            catch (ShopifyException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Theme with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Theme> Create(bool skipAddToCreatedList = false, bool fromZipUrl = false)
    {
        var theme = new Theme()
        {
            Name = (NamePrefix + Guid.NewGuid()).Substring(0, 50),
            Role = Role,
        };
        var obj = fromZipUrl ? await Service.CreateAsync(theme, ZipUrl) : await Service.CreateAsync(theme);

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}