#nullable enable
using System.Text.Json;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Graph;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceParseGraphExtensionsTests
{
    private class GraphServiceWithExposedExtensionsParserFunction(ShopifyApiCredentials credentials)
        : GraphService(credentials, apiVersion: null, shopifyDomainUtility: null)
    {
        public GraphExtensions? ParseGraphExtensions(string jsonReturnedFromRequestToShopify, string? requestIdFromHeaders) =>
            base.ParseGraphExtensions(JsonDocument.Parse(jsonReturnedFromRequestToShopify), requestIdFromHeaders);
    }

    private readonly GraphServiceWithExposedExtensionsParserFunction _sut = new(Utils.Credentials);

    public static string[] GetJsonForNullExtensionsPropertyTest() =>
    [
        """ { "data": { "foo": "bar" }, "extensions": {} } """,
        """ { "data": { "foo": "bar" }, "extensions": null } """,
        """ { "data": { "foo": "bar" } } """,
    ];

    public static (string Json, JsonValueKind JsonKind)[] GetJsonForInvalidTypeExtensionsPropertyTest() =>
    [
        (""" { "data": { "foo": "bar" }, "extensions": true } """, JsonValueKind.True),
        (""" { "data": { "foo": "bar" }, "extensions": false } """, JsonValueKind.False),
        (""" { "data": { "foo": "bar" }, "extensions": "some string" } """, JsonValueKind.String),
        (""" { "data": { "foo": "bar" }, "extensions": 123 } """, JsonValueKind.Number),
        (""" { "data": { "foo": "bar" }, "extensions": ["an array"] } """, JsonValueKind.Array),
    ];

    [Fact]
    public void ParseGraphExtensions_ShouldDeserializeTheGraphExtensions()
    {
        // Setup
        const int expectedRequestedQueryCost = 3;
        const int expectedActualQueryCost = 3;
        const double expectedMaximumAvailable = 2000.0;
        const double expectedCurrentlyAvailable = 1997;
        const double expectedRestoreRate = 100.0;
        var responseJson =
            //lang=json
            $$"""
              {
                  "data": { "foo": "bar" },
                  "extensions": {
                      "cost": {
                          "requestedQueryCost": {{expectedRequestedQueryCost}},
                          "actualQueryCost": {{expectedActualQueryCost}},
                          "throttleStatus": {
                              "maximumAvailable": {{expectedMaximumAvailable}},
                              "currentlyAvailable": {{expectedCurrentlyAvailable}},
                              "restoreRate": {{expectedRestoreRate}}
                          }
                      }
                  }
              }
              """;
        var expectedExtensions = new GraphExtensions
        {
            Cost = new GraphRequestCostExtension
            {
                ActualQueryCost = expectedActualQueryCost,
                RequestedQueryCost = expectedRequestedQueryCost,
                ThrottleStatus = new GraphRequestCostThrottleStatusExtension
                {
                    RestoreRate = expectedRestoreRate,
                    CurrentlyAvailable = expectedCurrentlyAvailable,
                    MaximumAvailable = expectedMaximumAvailable
                }
            }
        };

        // Act
        var extensions = _sut.ParseGraphExtensions(responseJson, "some-request-id-from-headers");

        // Assert
        extensions.Should().BeEquivalentTo(expectedExtensions);
    }

    [Theory]
    [CombinatorialData]
    public void ParseGraphExtensions_WhenTheJsonDoesNotContainExtensions_ShouldReturnNull([CombinatorialMemberData(nameof(GetJsonForNullExtensionsPropertyTest))] string json)
    {
        // Act
        var extensions = _sut.ParseGraphExtensions(json, "some-request-id-from-headers");

        // Assert
        extensions.Should().BeNull();
    }

    [Fact]
    public void ParseGraphExtensions_WhenGivenInvalidJson_ShouldThrowAShopifyJsonParseException()
    {
        const string responseJson =
            """
              {
                  "data": { "foo": "bar" },
                  "extensions": {
                      "cost": {
                          "requestedQueryCost": [],
                          "actualQueryCost": 3,
                          "throttleStatus": {
                              "maximumAvailable": 7
                          }
                      }
                  }
              }
              """;
        const string expectedRequestId = "some-expected-request-id";

        // Act
        var act = () => _sut.ParseGraphExtensions(responseJson, expectedRequestId);

        // Assert
        var exn = act.Should()
            .Throw<ShopifyJsonParseException>();
        var innerExn = exn.WithInnerException(typeof(JsonException))
            .And.As<JsonException>();

        exn.Which.RequestId.Should().Be(expectedRequestId);
        exn.Which.JsonPropertyName.Should().NotBeNullOrEmpty().And.Be(innerExn.Path);
        innerExn.Path.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [CombinatorialData]
    public void ParseGraphExtensions_WhenTheExtensionsObjectDoesNotMatchTheExpectedPrimitiveType_ShouldThrowAShopifyJsonParseException(
        [CombinatorialMemberData(nameof(GetJsonForInvalidTypeExtensionsPropertyTest))] (string Json, JsonValueKind JsonKind) theoryData
    )
    {
        const string expectedRequestId = "some-expected-request-id";
        var (json, jsonValueKind) = theoryData;

        // Act
        var act = () => _sut.ParseGraphExtensions(json, expectedRequestId);

        // Assert
        var exn = act.Should()
            .Throw<ShopifyJsonParseException>()
            .WithMessage($"The JSON response from Shopify contains an invalid 'extensions' property of type '{jsonValueKind}', but a property of type 'Object' is required.");
        exn.And.JsonPropertyName.Should().Be("$.extensions");
        exn.And.RequestId.Should().Be(expectedRequestId);
        exn.And.InnerException.Should().BeNull();
    }
}
