#if NET7_0_OR_GREATER
using ShopifySharp.GraphQL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Wish.GraphQLSchemaGenerator;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "GraphQL")]
    public class GenerateGraphQLSchema_Test
    {
        [Fact(Skip = "This test should be run manually to re-generate the GraphQL types whenever the API version is upgraded")]
        public async Task GenerateGraphQLTypes()
        {
            var scalarNameToTypeName = new Dictionary<string, string>
            {
                { "UnsignedInt64", "ulong" },
                { "Money", "decimal" },
                { "Decimal", "decimal" },
                { "DateTime", "DateTime" },//GraphQL datetimes are always UTC
                { "Date", "DateOnly" },
                { "UtcOffset", "TimeSpan" },
                { "URL", "string" },
                { "HTML", "string" },
                { "JSON", "string" },
                { "FormattedString", "string" },
                { "ARN", "string" },
                { "StorefrontID", "string" }
            };
            string csharpCode = await new GraphQLTypeGenerator().GenerateTypesAsync("ShopifySharp.GraphQL", scalarNameToTypeName, async query =>
            {
                var res = await new GraphService(Utils.MyShopifyUrl, Utils.AccessToken).PostAsync(query);
                var doc = JsonDocument.Parse(res.ToString());
                return doc;
            });

            var strCode = new StringBuilder()
                                .AppendLine("#if NET6_0_OR_GREATER")
                                .AppendLine(csharpCode)
                                .AppendLine("#endif");

            File.WriteAllText(@"../../../../ShopifySharp/Entities/GraphQL/GraphQLSchema.generated.cs", strCode.ToString());
        }

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
        public async Task GetProductsAsParameterizedJsonQuery()
        {
            var svc = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
            svc.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

            var parameterizedQuery = new
            {
                query = @"
                        query ($limit: Int!) { 
                            products(first:$limit) { 
                                nodes { 
                                    id 
                                } 
                             } 
                        }",
                variables = new
                {
                    limit = 10,
                }
            };

            var queryAsJson = Serializer.Serialize(parameterizedQuery);
            var res = await svc.SendAsync<ProductConnection>(queryAsJson, "application/json");
            var orders = res.nodes;
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
        }
    }
}
#endif