using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp.Tests
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using Xunit;

    public class DateTime_Tests : IClassFixture<Order_Tests_Fixture>
    {
        public DateTime_Tests(Order_Tests_Fixture orderTestsFixture)
        {
            this.OrderTestsFixture = orderTestsFixture;
        }

        public Order_Tests_Fixture OrderTestsFixture { get; }

        [Fact]
        public async Task GraphQL_CompareOrderDates()
        {
            var orderId = this.OrderTestsFixture.Created.First().Id.Value;

            var order = await this.OrderTestsFixture.Service.GetAsync(orderId);
            Assert.NotNull(order.UpdatedAt);

            // Shopify seems to take approx. 10 seconds to propagate new orders into the GraphQL API
            await Task.Delay(TimeSpan.FromSeconds(11));

            var graphService = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
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

            var jtokenOrder = graphQlOrder["orders"]["edges"].First["node"];

            var testOrder = jtokenOrder.ToObject<TestGraphQLOrderWithString>();
            var testOrderDateTime = DateTimeOffset.Parse(testOrder.UpdatedAt, CultureInfo.InvariantCulture);
            Assert.Equal(order.UpdatedAt.Value, testOrderDateTime);

            var testOrderWithDateTimeOffset = jtokenOrder.ToObject<TestGraphQLOrderWithDateTimeOffset>();
            Assert.Equal(order.UpdatedAt.Value, testOrderWithDateTimeOffset.UpdatedAt);

            var testOrderWithDateTime = jtokenOrder.ToObject<TestGraphQLOrderWithDateTime>();
            Assert.Equal(order.UpdatedAt.Value, testOrderWithDateTime.UpdatedAt);
        }

        public class TestGraphQLOrderWithString
        {
            public string UpdatedAt { get; set; }
        }

        public class TestGraphQLOrderWithDateTime
        {
            public DateTime UpdatedAt { get; set; }
        }

        public class TestGraphQLOrderWithDateTimeOffset
        {
            public DateTimeOffset UpdatedAt { get; set; }
        }
    }
}
