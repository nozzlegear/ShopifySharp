using ShopifySharp.Services.Graph;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products;

[Collection("Product Queries")]
public class ProductQueryTests(VerifyFixture verifyFixture, GraphServiceFixture graphServiceFixture)
    : IClassFixture<VerifyFixture>, IClassFixture<GraphServiceFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;
    private readonly IGraphService _sut = graphServiceFixture.Service;

    [Fact]
    public async Task ProductsQuery_ShouldListProducts()
    {
        var request = new GraphRequest
        {
            // lang=graphql
            Query = """
                    query getProducts($first: Int) {
                        products(first: $first) {
                            pageInfo {
                                startCursor
                                endCursor
                                hasNextPage
                                hasPreviousPage
                            }
                            nodes {
                                id
                                title
                                handle
                                description(truncateAt: 60)
                                legacyResourceId
                                publishedAt
                                status
                                variants(first: 3) {
                                    pageInfo {
                                        startCursor
                                        endCursor
                                        hasNextPage
                                        hasPreviousPage
                                    }
                                    nodes {
                                        id
                                        availableForSale
                                        displayName
                                        sku
                                        inventoryQuantity
                                        legacyResourceId
                                        selectedOptions {
                                            name
                                            value
                                            details: optionValue {
                                                id
                                            }
                                        }
                                        image {
                                            id
                                            altText
                                            url
                                        }
                                    }
                                }
                            }
                        }
                    }
                    """,
            Variables = new Dictionary<string, object>
            {
                {"first", 3}
            },
            UserErrorHandling = GraphRequestUserErrorHandling.Throw,
        };
        var products = await _sut.PostAsync<GetProductsQueryResponse>(request);

        await Verify(products, _verifySettings);
    }

    private class GetProductsQueryResponse
    {
        public required Products Products { get; set; }
    }

    private class Products
    {
        public required ICollection<ShopifySharp.GraphQL.Product> Nodes { get; set; }

        public required PageInfo PageInfo { get; set; }
    }
}
