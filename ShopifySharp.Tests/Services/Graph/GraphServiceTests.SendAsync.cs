#if NET8_0_OR_GREATER
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure.Serialization.Http;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using Xunit;
using Serializer = ShopifySharp.Infrastructure.Serializer;
using FakeItEasy;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceSendAsyncTests
{
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

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethod_ShouldDeserializeSingleChildPropertyOfDataToResult(
        [CombinatorialMemberData(nameof(GetOrdersTestPolicies), null)] IRequestExecutionPolicy policy
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
                }, {
                  "id" : "gid://shopify/Order/2275319238",
                  "createdAt" : "2016-01-07T16:37:04Z",
                  "name" : "#1003",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/2276382918",
                  "createdAt" : "2016-01-07T20:40:46Z",
                  "name" : "#1004",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/2299017414",
                  "createdAt" : "2016-01-13T17:49:09Z",
                  "name" : "#1005",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/2300111622",
                  "createdAt" : "2016-01-13T21:41:56Z",
                  "name" : "#1006",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/2681387846",
                  "createdAt" : "2016-04-01T20:15:21Z",
                  "name" : "#1007",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/3052034118",
                  "createdAt" : "2016-05-04T21:32:45Z",
                  "name" : "#1008",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 2
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/3076231174",
                  "createdAt" : "2016-05-06T14:17:17Z",
                  "name" : "#1009",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                }, {
                  "id" : "gid://shopify/Order/3799668102",
                  "createdAt" : "2016-07-17T05:28:00Z",
                  "name" : "#1010",
                  "phone" : null,
                  "lineItems" : {
                    "nodes" : [ {
                      "title" : "The Spud Who Loved Me",
                      "quantity" : 1
                    } ]
                  }
                } ]
              }
            },
            "extensions" : {
              "cost" : {
                "requestedQueryCost" : 30,
                "actualQueryCost" : 18,
                "throttleStatus" : {
                  "maximumAvailable" : 2000.0,
                  "currentlyAvailable" : 1982,
                  "restoreRate" : 100.0
                }
              }
            }
          }
          """;
        const string query =
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
        var service = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
        service.SetExecutionPolicy(policy);

        // Act
        var result = await service.SendAsync<OrderConnection>(query);

        // Assert
        var orders = result.nodes;

        orders.Should()
          .NotBeNullOrEmpty()
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

    [Theory(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsUserErrors()
    {
      Assert.Fail("NYI");
    }

    [Fact(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsMultipleChildProperties()
    {
      Assert.Fail("NYI");
    }

    [Fact(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsZeroChildProperties()
    {
      Assert.Fail("NYI");
    }

    [Fact(DisplayName = "Deprecated SendAsync<TResult> should deserialize the single child property of data to TResult")]
    public async Task SendAsync_T_DeprecatedMethod_ShouldThrowWhenResultContainsUserErrors()
    {
      Assert.Fail("NYI");
    }

    [Theory(DisplayName = "Deprecated SendAsync<TResult> (with variables) should deserialize the single child property of data to TResult")]
    [CombinatorialData]
    public async Task SendAsync_T_DeprecatedMethodWithVariables_ShouldDeserializeSingleChildPropertyOfDataToResult(
        [CombinatorialMemberData(nameof(GetOrdersTestPolicies), null)] IRequestExecutionPolicy policy
    )
    {
        var svc = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken, null, null);
        svc.SetExecutionPolicy(policy);
        var res = await svc.SendAsync<OrderConnection>(new GraphRequest
        {
            query = @"
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
}",
            variables = new
            {
                firstOrders = 10,
                firstLineItems = 20
            }
        });
        var orders = res.nodes;
        Assert.True(orders.Count() > 0);
        var o = orders.First();
        Assert.True(o.name != null);
        Assert.True(o.lineItems.nodes.First().quantity != null);
        var commentEventEmbed = o as ICommentEventEmbed;
        Assert.NotNull(commentEventEmbed);
        Assert.NotNull(commentEventEmbed.AsOrder());
        Assert.Null(commentEventEmbed.AsCustomer());
    }
}
#endif
