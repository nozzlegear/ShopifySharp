using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.Services.Graph;

namespace ShopifySharp.Tests.Integration.Features.QueryBuilders;

[Collection("QueryBuilder Queries")]
public class QueryBuilderTests(VerifyFixture verifyFixture, GraphServiceFixture graphServiceFixture)
    : IClassFixture<VerifyFixture>, IClassFixture<GraphServiceFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;
    private readonly IGraphService _sut = graphServiceFixture.Service;

    #region Shop Queries

    [Fact]
    public async Task QueryBuilder_ShouldRetrieveShop()
    {
        // Setup
        var query = new ShopOperationQueryBuilder()
            .Name()
            .CreatedAt()
            .Id();
        var request = GraphRequest.FromQueryBuilder(query);

        // Act
        var result = await _sut.PostAsync(request);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.name.Should().NotBeNullOrEmpty();
        result.Data.createdAt.Should().NotBeNull().And.NotBe(default);
        result.Data.id.Should().NotBeNullOrEmpty();

        await Verify(result.Data, _verifySettings);
    }

    [Fact]
    public async Task QueryBuilder_WhenAliasNameIsSet_ShouldDeserializeResponse()
    {
        // Setup
        var query = new ShopOperationQueryBuilder()
            .WithAlias("foo")
            .Name()
            .CreatedAt()
            .Id();
        var request = GraphRequest.FromQueryBuilder(query);

        // Act
        var result = await _sut.PostAsync(request);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.name.Should().NotBeNullOrEmpty();
        result.Data.createdAt.Should().NotBeNull().And.NotBe(default);
        result.Data.id.Should().NotBeNullOrEmpty();

        await Verify(result.Data, _verifySettings);
    }

    #endregion

    #region Paginated Queries with Arguments

    [Fact]
    public async Task QueryBuilder_WhenBuildingPaginatedQueryWithArguments_ShouldRetrieveArticles()
    {
        // Setup
        var query = new ArticlesOperationQueryBuilder();
        query.Arguments
            .First(5)
            .SortKey(ArticleSortKeys.UPDATED_AT)
            .Reverse(true);
        query.Nodes(nodes => nodes
            .Id()
            .Title()
            .Handle()
            .CreatedAt()
            .UpdatedAt());
        query.PageInfo(pageInfo => pageInfo
            .HasNextPage()
            .HasPreviousPage()
            .StartCursor()
            .EndCursor());

        var request = GraphRequest.FromQueryBuilder(query);

        // Act
        var result = await _sut.PostAsync(request);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.nodes.Should().NotBeNull();
        result.Data.pageInfo.Should().NotBeNull();
    }

    [Fact]
    public async Task QueryBuilder_WhenUsingCursorPagination_ShouldRetrieveNextPage()
    {
        // Setup
        var firstPageQuery = new ArticlesOperationQueryBuilder();
        firstPageQuery.Arguments.First(2);
        firstPageQuery.Nodes(nodes => nodes.Id().Title());
        firstPageQuery.PageInfo(pageInfo => pageInfo.HasNextPage().EndCursor());

        var firstPageRequest = GraphRequest.FromQueryBuilder(firstPageQuery);
        var firstPageResult = await _sut.PostAsync(firstPageRequest);

        // Fail if there's no next page
        if (firstPageResult.Data.pageInfo?.hasNextPage != true)
            Assert.Fail("Expected pageInfo.hasNextPage to be true, but it was false or null");

        // Get the second page using the cursor
        var secondPageQuery = new ArticlesOperationQueryBuilder();
        secondPageQuery.Arguments
            .First(2)
            .After(firstPageResult.Data.pageInfo.endCursor);
        secondPageQuery.Nodes(nodes => nodes.Id().Title());
        secondPageQuery.PageInfo(pageInfo => pageInfo.HasNextPage().EndCursor());

        var secondPageRequest = GraphRequest.FromQueryBuilder(secondPageQuery);

        // Act
        var secondPageResult = await _sut.PostAsync(secondPageRequest);

        // Assert
        secondPageResult.Data.Should().NotBeNull();
        secondPageResult.Data.nodes.Should().NotBeNull();

        // The second page should have different articles from the first page
        var firstPageIds = firstPageResult.Data.nodes?.Select(n => n?.id).ToList() ?? [];
        var secondPageIds = secondPageResult.Data.nodes?.Select(n => n?.id).ToList() ?? [];
        secondPageIds.Should().NotIntersectWith(firstPageIds);
    }

    #endregion
}
