using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests.Services;

[Trait("Category", "ScriptTag")]
[TestSubject(typeof(ScriptTagService))]
public class ScriptTagTests(ScriptTagTestsFixture fixture) : IClassFixture<ScriptTagTestsFixture>
{
    private readonly ScriptTagService _sut = fixture.Service;

    [Fact]
    public async Task CountAsync_ShouldCount()
    {
        // Act
        var count = await _sut.CountAsync();

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
        var list = await _sut.ListAsync(filter);

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
        var id = await fixture.GetExistingScriptTagIdOrCreateAsync();

        // Act
        var tag = await _sut.GetAsync(id);

        // Assert
        tag.Id.Should().Be(id);
        tag.Src.Should().Be(ScriptTagTestsFixture.Src);
        tag.Event.Should().Be(ScriptTagTestsFixture.Event);
        tag.DisplayScope.Should().Be(ScriptTagTestsFixture.Scope);
        tag.CreatedAt.Should().NotBeNull()
            .And.BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(30));
        tag.UpdatedAt.Should().NotBeNull()
            .And.BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(30));
    }

    [Fact]
    public async Task CreateAsync_ShouldCreate()
    {
        // Act
        var tag = await fixture.CreateScriptTagAsync();

        // Assert
        tag.Id.Should().BeGreaterThan(0);
        tag.Src.Should().Be(ScriptTagTestsFixture.Src);
        tag.Event.Should().Be(ScriptTagTestsFixture.Event);
        tag.DisplayScope.Should().Be(ScriptTagTestsFixture.Scope);
        tag.CreatedAt.Should().NotBeNull()
            .And.BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(30));
        tag.UpdatedAt.Should().NotBeNull()
            .And.BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(30));
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdate()
    {
        // Setup
        var expectedSrc = ScriptTagTestsFixture.Src + "?qs=some-expected-src";
        var created = await fixture.GetExistingScriptTagOrCreateAsync();
        created.Src = expectedSrc;

        // Act
        var updated = await _sut.UpdateAsync(created.Id!.Value, created);

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

    public Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
        return Task.CompletedTask;
    }

    public async Task DisposeAsync()
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
