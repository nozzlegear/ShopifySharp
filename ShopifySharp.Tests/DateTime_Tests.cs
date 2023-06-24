#nullable enable
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "DateTime"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
    public class DateTime_Tests : IClassFixture<Order_Tests_Fixture>
    {
        public DateTime_Tests(Order_Tests_Fixture orderTestsFixture)
        {
            OrderTestsFixture = orderTestsFixture;
        }

        private Order_Tests_Fixture OrderTestsFixture { get; }

        [Fact]
        public async Task GraphQL_CompareOrderDates()
        {
            var orderId = this.OrderTestsFixture.Created.First().Id!.Value;

            var order = await this.OrderTestsFixture.Service.GetAsync(orderId);
            Assert.NotNull(order.UpdatedAt);

            // Shopify seems to take approx. 10 seconds to propagate new orders into the GraphQL API
            await Task.Delay(TimeSpan.FromSeconds(11));

            var graphService = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
            graphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            var graphQlOrder = await graphService.PostAsync(
                                   @"
{
  orders(first:1,query:""id:" + orderId + @""") {  
            edges{
                node{
                    updatedAt
                }
            }
        }
    }
");

            var jTokenOrder = graphQlOrder["orders"]?["edges"]?.First?["node"]!;

            var testOrder = jTokenOrder.ToObject<TestGraphQlOrderWithString>()!;
            var testOrderDateTime = DateTimeOffset.Parse(testOrder.UpdatedAt ?? "", CultureInfo.InvariantCulture);
            Assert.Equal(order.UpdatedAt, testOrderDateTime);

            var testOrderWithDateTimeOffset = jTokenOrder.ToObject<TestGraphQlOrderWithDateTimeOffset>()!;
            Assert.Equal(order.UpdatedAt, testOrderWithDateTimeOffset.UpdatedAt);

            var testOrderWithDateTime = jTokenOrder.ToObject<TestGraphQlOrderWithDateTime>()!;
            Assert.Equal(order.UpdatedAt, testOrderWithDateTime.UpdatedAt);
        }

        [Serializable]
        public class TestGraphQlOrderWithString
        {
            public string? UpdatedAt { get; set; }
        }

        [Serializable]
        public class TestGraphQlOrderWithDateTime
        {
            public DateTime UpdatedAt { get; set; }
        }

        [Serializable]
        public class TestGraphQlOrderWithDateTimeOffset
        {
            public DateTimeOffset UpdatedAt { get; set; }
        }
    }
}
