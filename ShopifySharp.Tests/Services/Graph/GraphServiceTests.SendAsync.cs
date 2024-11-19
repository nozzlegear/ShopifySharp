#pragma warning disable CS0618 // Type or member is obsolete
#if NET8_0_OR_GREATER
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using Xunit;
using FakeItEasy;
using Serializer = ShopifySharp.Infrastructure.Serializer;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceSendAsyncTests
{
    private const string Query =
        """
        {
          orders(first:10)
          {
            nodes
            {
              id
              createdAt
              name
              phone
              lineItems(first: 10)
              {
                nodes
                {
                  title
                  quantity
                }
              }
            }
          }
        }
        """;

    private const string QueryWithVariables =
        """
        query ($firstOrders: Int!, $firstLineItems: Int!)
        {
          orders(first: $firstOrders)
          {
            nodes
            {
              id
              createdAt
              name
              phone
              lineItems(first: $firstLineItems)
              {
                nodes
                {
                  title
                  quantity
                }
              }
            }
          }
        }
        """;

    private static readonly object QueryVariables = new
    {
        firstOrders = 10,
        firstLineItems = 20
    };

    private static readonly GraphRequest GraphRequestForVariables = new() { query = QueryWithVariables, variables = QueryVariables };
    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>();
    private readonly GraphService _sut;

    public GraphServiceSendAsyncTests()
    {
        _sut = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
        _sut.SetExecutionPolicy(_executionPolicy);
    }

    public static IRequestExecutionPolicy[] GetOrdersTestPolicies()
    {
        return
        [
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new DefaultRequestExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new RetryExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new ExponentialRetryPolicy(ExponentialRetryPolicyOptions.Default())))
        ];
    }

    private static RequestResult<string> MakeRequestResult(string responseJson)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        return new RequestResult<string>(
            "some-request-info",
            response.Headers,
            responseJson,
            responseJson,
            "some-raw-link-header-value",
            HttpStatusCode.OK
        );
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldDeserializeSingleChildPropertyOfDataToResult(
        [CombinatorialMemberData(nameof(GetOrdersTestPolicies), null)] IRequestExecutionPolicy policy,
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
        var response = MakeRequestResult(expectedJson);

        _sut.SetExecutionPolicy(policy);
        A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        OrderConnection result;

        if (withVariables)
          result = await _sut.SendAsync<OrderConnection>(Query);
        else
          result = await _sut.SendAsync<OrderConnection>(GraphRequestForVariables);

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

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should throw when result contains user errors")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsUserErrors(bool withVariables)
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
        var response = MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphRequestForVariables);

        // Assert
        await act.Should().ThrowAsync<ShopifyGraphUserErrorsException>();
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
        var response = MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphRequestForVariables);

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
        var response = MakeRequestResult(expectedJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<OrderConnection>> act;

        if (withVariables)
          act = () => _sut.SendAsync<OrderConnection>(Query);
        else
          act = () => _sut.SendAsync<OrderConnection>(GraphRequestForVariables);

        // Assert
        await act.Should()
          .ThrowAsync<InvalidOperationException>()
          .WithMessage("Sequence contains no elements");
    }
}
#endif
