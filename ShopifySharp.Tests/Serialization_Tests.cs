using Newtonsoft.Json;
using System;
using System.Linq;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Serialization")]
    public class Serialization_Tests
    {
        [Fact]
        public void DeserializeOrderWithPropertiesAsArray()
        {
            string json = @"
{
  ""id"": 123,
  ""line_items"":
  [
    {
      ""id"": 456,
      ""properties"": [{name: ""myName"", value: ""myValue""}]
    }
  ]
}
";
            var order = JsonConvert.DeserializeObject<Order>(json);
            Assert.NotNull(order.LineItems.First().Properties);
            Assert.Equal("myName", order.LineItems.First().Properties.First().Name);
            Assert.Equal("myValue", order.LineItems.First().Properties.First().Value);
        }

        [Fact]
        public void DeserializeOrderWithPropertiesAsObjectInsteadOfArray()
        {
            string json = @"
{
  ""id"": 123,
  ""line_items"":
  [
    {
      ""id"": 456,
      ""properties"": {}
    }
  ]
}
";
            var order = JsonConvert.DeserializeObject<Order>(json);
            Assert.Null(order.LineItems.First().Properties);
        }

        [Fact]
        public void Ensure_Filter_Properties_Are_Nullable()
        {
            foreach (var pty in typeof(ShopifyService).Assembly
                                              .DefinedTypes
                                              .Where(t => t.Name.EndsWith("Filter"))
                                              .SelectMany(t => t.GetProperties()))
            {
                bool isNullable = !pty.PropertyType.IsValueType || Nullable.GetUnderlyingType(pty.PropertyType) != null;
                Assert.True(isNullable, $"Filter property {pty.DeclaringType.Name}.{pty.Name} is not nullable");
            }
        }
    }
}
