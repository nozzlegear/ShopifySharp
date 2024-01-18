using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "Blog")]
public class Blog_Tests : IClassFixture<Blog_Tests_Fixture>
{
    private Blog_Tests_Fixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public Blog_Tests(Blog_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_Blogs()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_Blogs()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Gets_Blogs()
    {
        var id = Fixture.Created.First().Id.Value;
        var blog = await Fixture.Service.GetAsync(id);

        Assert.True(blog.Id.HasValue);
        Assert.StartsWith(Fixture.Title, blog.Title);
        Assert.Equal(blog.Commentable, Fixture.Commentable);
    }

    [Fact]
    public async Task Deletes_Blogs()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Blogs)} threw exception. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Creates_Blogs()
    {
        var created = await Fixture.Create();

        Assert.NotNull(created);
        Assert.StartsWith(Fixture.Title, created.Title);
        Assert.Equal(Fixture.Commentable, created.Commentable);
    }

    [Fact]
    public async Task Updates_Blogs()
    {
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.Commentable = "yes";
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal("yes", updated.Commentable);
    }
}

public class Blog_Tests_Fixture : IAsyncLifetime
{
    public BlogService Service { get; } = new BlogService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Blog> Created { get; } = new List<Blog>();

    public string Title => "ShopifySharp Test Blog";

    public string Commentable => "moderate";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        // Create one blog for methods like count, get, list, etc.
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
                    Console.WriteLine($"Failed to delete created Blog with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Blog> Create(bool skipAddToCreatedList = false)
    {
        var blog = await Service.CreateAsync(new Blog()
        {
            Title = $"{Title} #{Guid.NewGuid()}",
            Commentable = Commentable,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(blog);
        }

        return blog;
    }
}