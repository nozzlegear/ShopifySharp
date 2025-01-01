#if NET8_0_OR_GREATER
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure.Serialization.Http;
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
        ];
    }

    [Theory]
    [CombinatorialData]
    public async Task GetOrders(
        [CombinatorialMemberData(nameof(GetOrdersTestPolicies), null)] IRequestExecutionPolicy policy
    )
    {
        var svc = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
        svc.SetExecutionPolicy(policy);
        var res = await svc.SendAsync<OrderConnection>(@"
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
");
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

    [Fact]
    public async Task GetOrdersWithVariables()
    {
        foreach (var policy in new IRequestExecutionPolicy[]
                 {
                     new DefaultRequestExecutionPolicy(),
                     new RetryExecutionPolicy(),
                     new LeakyBucketExecutionPolicy()
                 })
        {
            var svc = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken, null, null);
            svc.SetExecutionPolicy(policy);
            var res = await svc.SendAsync<OrderConnection>(new GraphRequest
            {
                query =
                    @"
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
}
#endif
