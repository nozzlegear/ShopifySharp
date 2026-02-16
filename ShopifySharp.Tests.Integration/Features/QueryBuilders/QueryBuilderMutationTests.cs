using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders.Operations;

namespace ShopifySharp.Tests.Integration.Features.QueryBuilders;

[Collection("QueryBuilder Mutations")]
public class QueryBuilderMutationTests(GraphServiceFixture graphServiceFixture, ArticleMutationFixture articleFixture)
    : IClassFixture<GraphServiceFixture>, IClassFixture<ArticleMutationFixture>
{
    private readonly IGraphService _sut = graphServiceFixture.Service;
    private readonly string _blogId = articleFixture.BlogId;

    [Fact]
    public async Task QueryBuilder_WhenCreatingWithInputObject_ShouldCreateArticle()
    {
        // Setup
        var createInput = new ArticleCreateInput
        {
            author = new AuthorInput { name = "Test Author" },
            title = $"Integration Test Article {Guid.NewGuid():N}",
            body = "<p>This is a test article created by integration tests.</p>",
            blogId = _blogId,
            isPublished = false,
            tags = ["integration-test", "automated"]
        };

        var query = new ArticleCreateOperationQueryBuilder();
        query.Arguments.Article(createInput);
        query.Article(article => article
            .Id()
            .Title()
            .Body()
            .Handle()
            .IsPublished()
            .Tags());
        query.UserErrors(errors => errors.Field().Message().Code());

        var request = GraphRequest.FromQueryBuilder(query);
        string? createdId = null;

        try
        {
            // Act
            var result = await _sut.PostAsync(request);

            // Assert
            result.Data.userErrors.Should().BeNullOrEmpty("article creation should not have errors");
            result.Data.article.Should().NotBeNull();
            result.Data.article!.id.Should().NotBeNullOrEmpty();
            result.Data.article.title.Should().Be(createInput.title);
            result.Data.article.body.Should().Contain("test article");
            result.Data.article.isPublished.Should().BeFalse();
            result.Data.article.tags.Should().Contain("integration-test");

            createdId = result.Data.article.id;
        }
        finally
        {
            if (createdId != null)
                await DeleteArticleAsync(createdId);
        }
    }

    [Fact]
    public async Task QueryBuilder_WhenUpdatingWithInputObject_ShouldUpdateArticle()
    {
        // Setup
        var articleId = await CreateTestArticleAsync();
        var updateInput = new ArticleUpdateInput
        {
            title = $"Updated Article {Guid.NewGuid():N}",
            body = "<p>This article has been updated.</p>",
            tags = ["integration-test", "updated"]
        };

        var query = new ArticleUpdateOperationQueryBuilder();
        query.Arguments
            .Id(articleId)
            .Article(updateInput);
        query.Article(article => article
            .Id()
            .Title()
            .Body()
            .Tags());
        query.UserErrors(errors => errors.Field().Message().Code());

        var request = GraphRequest.FromQueryBuilder(query);

        try
        {
            // Act
            var result = await _sut.PostAsync(request);

            // Assert
            result.Data.userErrors.Should().BeNullOrEmpty("article update should not have errors");
            result.Data.article.Should().NotBeNull();
            result.Data.article!.id.Should().Be(articleId);
            result.Data.article.title.Should().Be(updateInput.title);
            result.Data.article.body.Should().Contain("has been updated");
            result.Data.article.tags.Should().Contain("updated");
        }
        finally
        {
            await DeleteArticleAsync(articleId);
        }
    }

    [Fact]
    public async Task QueryBuilder_WhenDeleting_ShouldDeleteArticle()
    {
        // Setup
        var articleId = await CreateTestArticleAsync();

        var query = new ArticleDeleteOperationQueryBuilder();
        query.Arguments.Id(articleId);
        query.DeletedArticleId();
        query.UserErrors(errors => errors.Field().Message().Code());

        var request = GraphRequest.FromQueryBuilder(query);

        // Act
        var result = await _sut.PostAsync(request);

        // Assert
        result.Data.userErrors.Should().BeNullOrEmpty("article deletion should not have errors");
        result.Data.deletedArticleId.Should().Be(articleId);
    }

    private async Task<string> CreateTestArticleAsync()
    {
        var createInput = new ArticleCreateInput
        {
            author = new AuthorInput { name = "Test Author" },
            title = $"Test Article {Guid.NewGuid():N}",
            body = "<p>Test article for mutation tests.</p>",
            blogId = _blogId,
            isPublished = false,
            tags = ["integration-test"]
        };

        var query = new ArticleCreateOperationQueryBuilder();
        query.Arguments.Article(createInput);
        query.Article(article => article.Id());
        query.UserErrors(errors => errors.Message());

        var request = GraphRequest.FromQueryBuilder(query);
        var result = await _sut.PostAsync(request);

        result.Data.article.Should().NotBeNull();
        return result.Data.article!.id!;
    }

    private async Task DeleteArticleAsync(string articleId)
    {
        var query = new ArticleDeleteOperationQueryBuilder();
        query.Arguments.Id(articleId);
        query.DeletedArticleId();

        var request = GraphRequest.FromQueryBuilder(query);
        await _sut.PostAsync(request);
    }
}
