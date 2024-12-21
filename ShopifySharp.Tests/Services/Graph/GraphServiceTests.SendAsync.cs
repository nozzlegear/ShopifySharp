#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete
#if NET6_0_OR_GREATER
using ShopifySharp.GraphQL;
#endif
using System;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using Xunit;
using Serializer = ShopifySharp.Infrastructure.Serializer;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceSendAsyncTests
{
    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>();
    private readonly IHttpContentSerializer _httpContentSerializer = A.Fake<IHttpContentSerializer>(x => x.Wrapping(new GraphHttpContentSerializer(Serializer.GraphSerializerOptions)));
    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>();
    private readonly GraphService _sut;

    public GraphServiceSendAsyncTests()
    {
        A.CallTo(() => _serviceProvider.GetService(typeof(IHttpContentSerializer)))
          .Returns(_httpContentSerializer);

        _sut = new GraphService(Utils.Credentials, _serviceProvider);
        _sut.SetExecutionPolicy(_executionPolicy);
    }

    public static IRequestExecutionPolicy[] MakeFakedExecutionPoliciesList() => Utils.MakeFakedExecutionPoliciesList();

    #if NET6_0_OR_GREATER

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should succeed")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldSucceed(
        [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList))] IRequestExecutionPolicy policy,
        bool withVariables
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "nodes" : [ {
                  "id" : "gid://shopify/Order/2134274438",
                  "createdAt" : "2015-12-07T21:14:23Z",
                  "name" : "#1001",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/2134447494",
                  "createdAt" : "2015-12-07T21:34:29Z",
                  "name" : "#1002",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        _sut.SetExecutionPolicy(policy);
        A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        OrderConnection result;

        if (withVariables)
          result = await _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.Query);
        else
          result = await _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.MakeGraphRequest());

        // Assert
        result.nodes
          .Should().NotBeNullOrEmpty()
          .And.AllSatisfy(o => o.name.Should().NotBeNull())
          .And.AllSatisfy(o =>
            o.lineItems?.nodes
              .Should().NotBeNullOrEmpty()
              .And.AllSatisfy(li =>
                li.quantity
                  .Should().NotBeNull()))
          .And.AllSatisfy(o =>
            o.Should().BeAssignableTo<ICommentEventEmbed>()
              .Which.Should().NotBeNull());
    }

    [Fact(DisplayName = "Deprecated SendAsync<TResult>(string graphQuery) should throw when result contains user errors")]
    public async Task SendAsync_T_DeprecatedMethod_WhenResultContainsUserErrors_ShouldThrow()
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "userErrors": [{ "code": "foo", "message": "bar" }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.Query);

        // Assert
        await act.Should().ThrowAsync<ShopifyGraphUserErrorsException>();
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult>(GraphRequest graphRequest) should throw when result contains user errors")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_AcceptingGraphRequestParameter_WhenResultContainsUserErrorsAndTheGraphRequestIsConfiguredToThrow_ShouldThrow(
        GraphRequestUserErrorHandling userErrorHandling
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "userErrors": [{ "code": "foo", "message": "bar" }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);
        var request = GraphServiceTestUtils.MakeGraphRequest(x => x.UserErrorHandling = userErrorHandling);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = () => _sut.SendAsync<OrderConnection>(request);

        // Assert
        if (userErrorHandling == GraphRequestUserErrorHandling.Throw)
            await act.Should().ThrowAsync<ShopifyGraphUserErrorsException>();
        else
            await act.Should().NotThrowAsync();
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should throw when result contains multiple child properties")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsMultipleChildProperties(bool withVariables)
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "nodes": []
              },
              "customers": {
                "nodes": []
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.MakeGraphRequest());

        // Assert
        await act.Should()
          .ThrowAsync<InvalidOperationException>()
          .WithMessage("Sequence contains more than one element");
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should throw when result contains zero child properties")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsZeroChildProperties(bool withVariables)
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : { }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.MakeGraphRequest());

        // Assert
        await act.Should()
          .ThrowAsync<InvalidOperationException>()
          .WithMessage("Sequence contains no elements");
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should throw when there is no root \"data\" property")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_WhenThereIsNoRootDataProperty_ShouldThrow(bool withVariables)
    {
        // Setup
        const string expectedJson =
          """
          {
            "foo": { }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphServiceTestUtils.MakeGraphRequest());

        // Assert
        await act.Should()
          .ThrowAsync<ShopifyJsonParseException>()
          .WithMessage("The JSON response from Shopify does not contain the expected 'data' property.")
          .Where(x => x.JsonPropertyName == "data");
    }

    #endif

    #region [Deprecated] Task<JsonElement> SendAsync(string graphqlQuery)

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(string graphqlQuery) should succeed")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithStringParameterReturningJsonElement_ShouldSucceed(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)] IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "nodes": []
              },
              "customers": {
                "nodes": []
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);

        _sut.SetExecutionPolicy(policy);
        A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = () => _sut.SendAsync(GraphServiceTestUtils.Query);

        // Assert
        await act.Should().NotThrowAsync();

        var data = await act();
        data.TryGetProperty("orders", out _).Should().BeTrue();
        data.TryGetProperty("customers", out _).Should().BeTrue();
    }

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(string graphqlQuery) should throw when there is no root \"data\" property")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithStringParameterReturningJsonElement_WhenThereIsNoRootDataProperty_ShouldThrow(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)]
      IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "foo": { }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);
        var policyCall = A.CallTo(policy).WithReturnType<Task<RequestResult<string>>>();

        _sut.SetExecutionPolicy(policy);
        policyCall.Returns(response);

        // Act
        var act = () => _sut.SendAsync(GraphServiceTestUtils.Query);

        // Assert
        await act.Should()
          .ThrowAsync<ShopifyJsonParseException>()
          .WithMessage("The JSON response from Shopify does not contain the expected 'data' property.")
          .Where(x => x.JsonPropertyName == "data");

        policyCall.MustHaveHappenedOnceOrMore();
    }

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(string graphqlQuery) should not throw when the root \"data\" property contains user errors")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithStringParameterReturningJsonElement_WhenTheRootDataPropertyContainsUserErrors_ShouldNotThrow(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)] IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "userErrors": [{ "code": "foo", "message": "bar" }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);
        var policyCall = A.CallTo(policy).WithReturnType<Task<RequestResult<string>>>();

        _sut.SetExecutionPolicy(policy);
        policyCall.Returns(response);

        // Act
        var act = () => _sut.SendAsync(GraphServiceTestUtils.Query);

        // Assert
        await act.Should().ThrowAsync<ShopifyGraphUserErrorsException>();
    }

    #endregion

    #region [Deprecated] Task<JsonElement> SendAsync(GraphRequest request)

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(GraphRequest request) should succeed")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithGraphRequestParameterReturningJsonElement_ShouldSucceed(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)] IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "nodes": []
              },
              "customers": {
                "nodes": []
              }
            }
          }
          """;
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();
        var response = Utils.MakeRequestResult(expectedJson);

        _sut.SetExecutionPolicy(policy);
        A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = () => _sut.SendAsync(graphRequest);

        // Assert
        await act.Should().NotThrowAsync();

        var data = await act();
        data.TryGetProperty("orders", out _).Should().BeTrue();
        data.TryGetProperty("customers", out _).Should().BeTrue();
    }

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(GraphRequest request) should prefer to use the graphqlQueryCost from parameters over the one from the GraphRequest")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithGraphRequestParameterReturningJsonElement_ShouldPreferGraphQueryCostFromParameters(
        [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList))] IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "nodes": []
              },
              "customers": {
                "nodes": []
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);
        const int expectedGraphRequestCost = 7;
        const int expectedGraphParameterCost = 11;
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest(x =>
        {
            x.EstimatedQueryCost = expectedGraphRequestCost;
        });

        var policyCall = A.CallTo(policy).WithReturnType<Task<RequestResult<string>>>();

        _sut.SetExecutionPolicy(policy);
        policyCall.Returns(response);

        // Act
        var act = () => _sut.SendAsync(graphRequest, expectedGraphParameterCost);

        // Assert
        await act.Should().NotThrowAsync();

        A.CallTo(() => _httpContentSerializer.SerializeGraphRequest(
            A<RequestUri>._,
            A<GraphRequest>.That.Matches(r => r.EstimatedQueryCost == expectedGraphParameterCost)))
          .MustHaveHappenedOnceExactly();
    }

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(GraphRequest request) should throw when there is no root \"data\" property")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithGraphRequestParameterReturningJsonElement_WhenThereIsNoRootDataProperty_ShouldThrow(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)]
      IRequestExecutionPolicy policy
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "foo": { }
          }
          """;
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();
        var response = Utils.MakeRequestResult(expectedJson);
        var policyCall = A.CallTo(policy).WithReturnType<Task<RequestResult<string>>>();

        _sut.SetExecutionPolicy(policy);
        policyCall.Returns(response);

        // Act
        var act = () => _sut.SendAsync(graphRequest);

        // Assert
        await act.Should()
          .ThrowAsync<ShopifyJsonParseException>()
          .WithMessage("The JSON response from Shopify does not contain the expected 'data' property.")
          .Where(x => x.JsonPropertyName == "data");

        policyCall.MustHaveHappenedOnceOrMore();
    }

    [Theory(DisplayName = "Deprecated SendAsync<JsonElement>(GraphRequest request) should throw when the root \"data\" property contains user errors and the GraphRequest is configured to throw")]
    [CombinatorialData]
    public async Task SendAsync_DeprecatedMethod_WithGraphRequestParameterReturningJsonElement_WhenTheRootDataPropertyContainsUserErrorsAndTheGraphRequestIsConfiguredToThrow_ShouldThrow(
      [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)] IRequestExecutionPolicy policy,
      GraphRequestUserErrorHandling userErrorHandling
    )
    {
        // Setup
        const string expectedJson =
          """
          {
            "data" : {
              "orders" : {
                "userErrors": [{ "code": "foo", "message": "bar" }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(expectedJson);
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest(x => x.UserErrorHandling = userErrorHandling);
        var policyCall = A.CallTo(policy).WithReturnType<Task<RequestResult<string>>>();

        _sut.SetExecutionPolicy(policy);
        policyCall.Returns(response);

        // Act
        var act = () => _sut.SendAsync(graphRequest);

        // Assert
        if (userErrorHandling == GraphRequestUserErrorHandling.Throw)
            await act.Should().ThrowAsync<ShopifyGraphUserErrorsException>();
        else
            await act.Should().NotThrowAsync();
    }

    #endregion
}
