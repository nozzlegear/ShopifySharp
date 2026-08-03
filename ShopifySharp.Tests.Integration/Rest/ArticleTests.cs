using System.Net;
using EmptyAssert = ShopifySharp.Tests.Integration.Rest.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "Article")]
public class ArticleTests(ArticleTestsFixture fixture, VerifyFixture verifyFixture)
    : IClassFixture<ArticleTestsFixture>, IClassFixture<VerifyFixture>
{
    private ArticleTestsFixture Fixture { get; } = fixture;

    [Fact]
    public async Task Counts_Articles()
    {
        // Act
        var count = await Fixture.Service.CountAsync(Fixture.BlogId!.Value, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        Assert.True(count > 0);
    }

    [Fact]
    public async Task Creates_Articles()
    {
        // Act
        var article = await Fixture.Create();

        // Assert
        await Verify(article, verifyFixture.Settings)
            .ScrubMember<ArticleImage>(a => a.Src)
            .ScrubMembers<Article>(
                a => a.Title,
                a => a.Handle
            );

        article.Handle.Should().NotBeEmpty();
        article.Tags.Should().NotBeEmpty();
        article.BlogId.Should().Be(Fixture.BlogId);
    }

    [Fact]
    public async Task Deletes_Articles()
    {
        // Setup
        var article = await Fixture.Create(true);

        // Act
        var act = async () => await Fixture.Service.DeleteAsync(Fixture.BlogId!.Value, article.Id!.Value, TestContext.Current.CancellationToken);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task Lists_Articles()
    {
        // Act
        var articles = await Fixture.Service.ListAsync(Fixture.BlogId!.Value, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        articles.Items.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Lists_Authors()
    {
        // Act
        var authors = await Fixture.Service.ListAuthorsAsync(TestContext.Current.CancellationToken);

        // Assert
        authors.Should().Contain(ArticleTestsFixture.Author);
    }

    [Fact]
    public async Task Lists_Tags()
    {
        // Act
        var tags = await Fixture.Service.ListTagsAsync(cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        tags.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Lists_Tags_For_Blog()
    {
        // Act
        var tags = await Fixture.Service.ListTagsForBlogAsync(Fixture.BlogId!.Value, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        tags.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Updates_Articles()
    {
        // Setup
        var html = "<h1>Updated!</h1>";
        var article = await Fixture.Create();
        article.BodyHtml = html;

        // Act
        article = await Fixture.Service.UpdateAsync(Fixture.BlogId!.Value, article.Id!.Value, article, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        article.BodyHtml.Should().Be(html, "article's BodyHtml should have been updated to the given html");
    }
}

public class ArticleTestsFixture : IAsyncLifetime
{
    public ArticleService Service { get; } = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public BlogService BlogService { get; } = new(Utils.MyShopifyUrl, Utils.AccessToken);

    public static string Title => "My new Article title - ";

    public static string Author => "John Smith";

    public static string Tags => "This Post, Has Been Tagged";

    public static string BodyHtml => "<h1>I like articles</h1>\n<p><strong>Yea</strong>, I like posting them through <span class=\"caps\">REST</span>.</p>";

    public long? BlogId { get; set; }

    public List<Article> Created { get; } = [];

    public async ValueTask InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        BlogService.SetExecutionPolicy(policy);

        var blogs = await BlogService.ListAsync();

        BlogId = blogs.Items.First().Id;

        // Create at least one article for list, count, etc commands.
        await Create();
    }

    public async ValueTask DisposeAsync()
    {
        foreach (var article in Created)
        {
            if (article.Id is null || BlogId is null)
                continue;

            try
            {
                await Service.DeleteAsync(BlogId!.Value, article.Id!.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete Article with id {article.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates the object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Article> Create(bool skipAddToDeleteList = false)
    {
        var obj = await Service.CreateAsync(BlogId.Value, new Article()
        {
            Title = Title + Guid.NewGuid(),
            Author = Author,
            Tags = Tags,
            BodyHtml = BodyHtml,
            Image = new ArticleImage()
            {
                Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
            }
        });

        if (!skipAddToDeleteList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
