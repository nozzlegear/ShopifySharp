#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.Tests.TestClasses;
using Xunit;
using Serializer = ShopifySharp.Infrastructure.Serializer;

namespace ShopifySharp.Tests.Services.Graph;

[Serializable]
public class GraphOrderEdge
{
    public string Cursor { get; set; } = null!;
    public GraphOrder Node { get; set; } = null!;
}

[Serializable]
public class GraphOrder
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public IEnumerable<string> Tags { get; set; } = [];
}

[Serializable]
public class GraphPageInfo
{
    public bool HasNextPage { get; set; }
    public bool HasPreviousPage { get; set; }
}

[Serializable]
public class GraphListOrdersResult
{
    public GraphPageInfo PageInfo { get; set; } = null!;
    public Collection<GraphOrderEdge> Edges { get; set; } = [];
}

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceTests
{
    private readonly ShopifyApiCredentials _credentials = new("some-shopify-domain", "some-access-token");

    private readonly JsonSerializerOptions _jsonSerializerOptions = Serializer.GraphSerializerOptions;
    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy()));
    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>();
    private readonly IHttpContentSerializer _httpContentSerializer;

    private readonly GraphService _sut;

    public GraphServiceTests()
    {
        _httpContentSerializer = A.Fake<IHttpContentSerializer>(x =>
            x.Wrapping(new GraphHttpContentSerializer(_jsonSerializerOptions)));

        A.CallTo(() => _serviceProvider.GetService(typeof(JsonSerializerOptions)))
            .Returns(_jsonSerializerOptions);
        A.CallTo(() => _serviceProvider.GetService(typeof(IHttpContentSerializer)))
            .Returns(_httpContentSerializer);

        _sut = new GraphService(_credentials, _serviceProvider);
        _sut.SetExecutionPolicy(_executionPolicy);
    }

    [Fact]
    public async Task WhenSendingGraphRequest_ShouldUseHttpContentSerializer()
    {
        // Setup
        var request = new GraphRequest
        {
            //language=txt
            Query = "some-graph-request-query",
            Variables = new Dictionary<string, object>
            {
                { "foo", "bar" }
            }
        };

        A.CallTo(() => _httpContentSerializer.SerializeGraphRequest(A<RequestUri>._, request))
            .Throws<TestException>();

        // Act
        var act = () => _sut.PostAsync(request);

        // Assert
        await act.Should().ThrowAsync<TestException>();
    }

    [Fact]
    public async Task WhenDeserializingUnionTypesForSubscriptionContract_ShouldNotThrow()
    {
        const string json =
            """
            {
              "data": {
                "subscriptionContract": {
                  "id": "gid://shopify/SubscriptionContract/some-contract-id",
                  "discounts": {
                    "edges": [
                      {
                        "node": {
                          "id": "gid://shopify/SubscriptionManualDiscount/some-discount-id",
                          "value": {
                            "__typename": "SubscriptionDiscountPercentageValue",
                            "percentage": 10
                          }
                        }
                      }
                    ]
                  },
                  "customerPaymentMethod": {
                    "id": "gid://shopify/CustomerPaymentMethod/some-payment-id",
                    "revokedReason": "PAYMENT_METHOD_VERIFICATION_FAILED",
                    "revokedAt": null,
                    "instrument": {
                      "__typename": "CustomerCreditCard",
                      "brand": "visa",
                      "expiresSoon": false,
                      "expiryMonth": 12,
                      "expiryYear": 2025,
                      "lastDigits": "4242",
                      "isRevocable": false,
                      "maskedNumber": "•••• •••• •••• 4242",
                      "name": "name",
                      "source": "credit_card"
                    }
                  }
                }
              }
            }
            """;

        // Act
        var document = JsonDocument.Parse(json);
        var element = new SystemJsonElement(document.RootElement.GetProperty("data"));
        var systemJsonSerializer = new SystemJsonSerializer(Serializer.GraphSerializerOptions);
        var result = await systemJsonSerializer.DeserializeAsync<GetSubscriptionContractResult>(element);

        // Assert
        result.Should().NotBeNull();
        result.subscriptionContract.id.Should().Be("gid://shopify/SubscriptionContract/some-contract-id");

        result.subscriptionContract.customerPaymentMethod.Should().NotBeNull();
        result.subscriptionContract.customerPaymentMethod!.id.Should().Be("gid://shopify/CustomerPaymentMethod/some-payment-id");
        result.subscriptionContract.customerPaymentMethod!.revokedReason.Should().Be(CustomerPaymentMethodRevocationReason.PAYMENT_METHOD_VERIFICATION_FAILED);

        var instrument = result.subscriptionContract.customerPaymentMethod.instrument!.AsCustomerCreditCard();
        instrument.Should().NotBeNull()
            .And.BeOfType<CustomerCreditCard>()
            .Which
            .Should()
            .BeEquivalentTo(new CustomerCreditCard
            {
                brand = "visa",
                expiresSoon = false,
                expiryMonth = 12,
                expiryYear = 2025,
                lastDigits = "4242",
                isRevocable = false,
                maskedNumber = "•••• •••• •••• 4242",
                name = "name",
                source = "credit_card"
            });
    }

    public record GetSubscriptionContractResult(SubscriptionContract subscriptionContract);
}
