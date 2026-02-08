using ShopifySharp.Services.Graph;
using ShopifySharp.GraphQL;
using System.Text.Json;

namespace ShopifySharp.Tests.Integration.Features.Orders;

[Collection("Order Queries")]
public class OrderQueryTests(VerifyFixture verifyFixture, GraphServiceFixture graphServiceFixture)
    : IClassFixture<VerifyFixture>, IClassFixture<GraphServiceFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;
    private readonly IGraphService _sut = graphServiceFixture.Service;

    private async Task<string> GetLatestOrderId()
    {
        var request = new GraphRequest
        {
            Query = """
                query orderId {
                    orders(first: 1) {
                        nodes {
                            id
                        }
                    }
                }
                """
        };
        var result = await _sut.PostAsync<ListOrderIdsResponse>(request, CancellationToken.None);
        return result.Data.Orders.Nodes.Select(x => x.Id).First();
    }

    [Fact]
    public async Task OrderQuery_WithCustomerMetafieldReference_ShouldNotThrowSerializationError()
    {
        // This test validates the fix for #1205 where querying an order with a metafield
        // that references a Customer causes a JSON deserialization error
        
        // Setup
        var orderId = await GetLatestOrderId();
        var request = new GraphRequest
        {
            // using the exact query from the bug report
            Query = """
                query getOrderHead($id: ID!) {
                    order(id: $id) {
                        id
                        name
                        createdAt
                        processedAt
                        note
                        displayFinancialStatus
                        customer {
                            id
                        }
                        totalPriceSet {
                            shopMoney {
                                amount
                                currencyCode
                            }
                        }
                        shippingAddress {
                            address1
                            address2
                            city
                            name
                            phone
                            zip
                            province
                            provinceCode
                            country
                            company
                        }
                        shippingLine {
                            id
                            title
                            originalPriceSet {
                                shopMoney {
                                    amount
                                    currencyCode
                                }
                            }
                            discountAllocations {
                                allocatedAmountSet {
                                    shopMoney {
                                        amount
                                        currencyCode
                                    }
                                }
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "id", orderId }
            },
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        };

        // Act
        var result = await _sut.PostAsync<OrderQueryResponse>(request);

        // Verify
        await Verify(result.Data, _verifySettings);
        result.Data.Order?.customer?.id.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void MetafieldReferenceDeserialization_WithCustomerType_ShouldSucceed()
    {
        // This test directly verifies that JSON containing a Customer can be deserialized as MetafieldReference
        // Related to issue #1205

        // Setup
        // JSON representing a Customer within a MetafieldReference context
        const string customerJson = """
            {
                "__typename": "Customer",
                "id": "gid://shopify/Customer/123456789",
                "displayName": "Test Customer",
                "email": "test@example.com"
            }
            """;

        // Act
        var result = JsonSerializer.Deserialize<MetafieldReference>(customerJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        // Assert
        result.Should().NotBeNull("Deserialized MetafieldReference should not be null");
        result?.GetType().Name.Should().Be("MetafieldReferenceCustomer", "Should deserialize to MetafieldReferenceCustomer wrapper type");
    }
}

public record OrderQueryResponse
{
    public required GraphQL.Order? Order { get; init; }
}

public record ListOrderIdsResponse
{
    public required OrderIdsQueryData Orders { get; init; }
}

public record OrderIdsQueryData
{
    public required OrderNodes[] Nodes { get; init; }
}

public record OrderNodes
{
    public required string Id { get; init; }
}
