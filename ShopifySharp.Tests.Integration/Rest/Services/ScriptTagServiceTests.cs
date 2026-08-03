using System.Net;
using JetBrains.Annotations;
using ShopifySharp.Filters;

namespace ShopifySharp.Tests.Integration.Rest.Services;

[Trait("Category", "ScriptTag")]
[TestSubject(typeof(ScriptTagService))]
public class ScriptTagTests(ScriptTagTestsFixture fixture, VerifyFixture verifyFixture)
    : IClassFixture<ScriptTagTestsFixture>, IClassFixture<VerifyFixture>
{
    private readonly ScriptTagService _sut = fixture.Service;

    private async Task VerifyScriptTag(ScriptTag tag) =>
        await Verify(tag, verifyFixture.Settings)
            .ScrubLinesWithReplace(line =>
            {
                if (!line.StartsWith(ScriptTagTestsFixture.Src))
                    return line;
                return ScriptTagTestsFixture.Src + " – {Scrubbed}";
            });

    [Fact]
    public async Task CountAsync_ShouldCount()
    {
        // Act
        var count = await _sut.CountAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        count.Should().BeGreaterThan(0);
    }

    [Fact]
    public async Task ListAsync_ShouldList()
    {
        // Setup
        const int limit = 5;
        var filter = new ScriptTagListFilter { Limit = limit };

        // Act
        var list = await _sut.ListAsync(filter, TestContext.Current.CancellationToken);

        // Assert
        list.Items
            .Should().HaveCount(limit)
            .And.AllSatisfy(tag =>
            {
                tag.Id.Should().BeGreaterThan(0);
                tag.Src.Should().NotBeNullOrWhiteSpace();
                tag.DisplayScope.Should().BeOneOf("all", ScriptTagTestsFixture.Scope);
                tag.Event.Should().Be(ScriptTagTestsFixture.Event);
                tag.CreatedAt.Should().NotBeNull();
                tag.UpdatedAt.Should().NotBeNull();
            });
    }

    [Fact]
    public async Task DeleteAsync_ShouldDelete()
    {
        // Setup
        var created = await fixture.CreateScriptTagAsync(true);

        // Act
        var act = async () => await _sut.DeleteAsync(created.Id!.Value);

        // Assert
        await act.Should().NotThrowAsync("deleting script tag with id {0} should not fail", created.Id);
    }

    [Fact]
    public async Task GetAsync_ShouldGet()
    {
        // Setup
        var created = await fixture.CreateScriptTagAsync();
        var id = created.Id!.Value;

        // Act
        var tag = await _sut.GetAsync(id, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        await VerifyScriptTag(tag);

        tag.Id.Should().Be(id);
        // Shopify appends a query string to script tag URLs
        tag.Src.Should().StartWith(ScriptTagTestsFixture.Src);
        tag.Event.Should().Be(ScriptTagTestsFixture.Event);
        tag.DisplayScope.Should().Be(ScriptTagTestsFixture.Scope);
        tag.CreatedAt.Should().NotBeNull()
            .And.NotBe(DateTimeOffset.MinValue);
        tag.UpdatedAt.Should().NotBeNull()
            .And.NotBe(DateTimeOffset.MinValue);
    }

    [Fact]
    public async Task Creates_ScriptTag_ShouldCreate()
    {
        // Act
        var tag = await fixture.CreateScriptTagAsync();

        // Assert
        await VerifyScriptTag(tag);

        tag.Id.Should().BeGreaterThan(0);
        // Shopify appends a query string to script tag URLs
        tag.Src.Should().StartWith(ScriptTagTestsFixture.Src);
        tag.Event.Should().Be(ScriptTagTestsFixture.Event);
        tag.DisplayScope.Should().Be(ScriptTagTestsFixture.Scope);
        tag.CreatedAt.Should().NotBeNull()
            .And.NotBe(DateTimeOffset.MinValue);
        tag.UpdatedAt.Should().NotBeNull()
            .And.NotBe(DateTimeOffset.MinValue);
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdate()
    {
        // Setup
        var expectedSrc = ScriptTagTestsFixture.Src + "?qs=some-expected-src";
        var created = await fixture.GetExistingScriptTagOrCreateAsync();
        created.Src = expectedSrc;

        // Act
        var updated = await _sut.UpdateAsync(created.Id!.Value, created, TestContext.Current.CancellationToken);

        // Assert
        updated.Src.Should().Be(expectedSrc);
    }
}

[UsedImplicitly]
public class ScriptTagTestsFixture : IAsyncLifetime
{
    private List<ScriptTag> Created { get; } = [];

    public ScriptTagService Service { get; } = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public static string Event => "onload";

    public static string Src => "https://unpkg.com/davenport@2.1.0/bin/browser.js";

    public static string Scope => "online_store";

    public ValueTask InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
        return default;
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
                    Console.WriteLine($"Failed to delete created ScriptTag with id {obj.Id!.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<ScriptTag> CreateScriptTagAsync(bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new ScriptTag()
        {
            Event = Event,
            Src = Src,
            DisplayScope = Scope,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }

    /// <summary>
    /// Gets one of the existing script tags in the fixtures <see cref="Created"/> list. If no script tags exist,
    /// one will be created.
    /// </summary>
    public async Task<ScriptTag> GetExistingScriptTagOrCreateAsync()
    {
        if (Created.FirstOrDefault() is { } x)
            return x;

        return await CreateScriptTagAsync();
    }

    /// <summary>
    /// Gets the id of one of the existing script tags in the fixtures <see cref="Created"/> list. If no script tags exist,
    /// one will be created.
    /// </summary>
    public async Task<long> GetExistingScriptTagIdOrCreateAsync()
    {
        var tag = await GetExistingScriptTagOrCreateAsync();
        return tag.Id!.Value;
    }
}
