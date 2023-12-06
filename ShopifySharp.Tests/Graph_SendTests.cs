#if NET7_0_OR_GREATER
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.GraphQL;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Graph")]
    public class Graph_SendTests
    {
        [Fact]
        public async Task GetOrders()
        {
            foreach (var policy in new IRequestExecutionPolicy[]
            {
                new DefaultRequestExecutionPolicy(),
                new RetryExecutionPolicy(),
                new LeakyBucketExecutionPolicy()
            })
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
                var svc = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
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
}
#endif