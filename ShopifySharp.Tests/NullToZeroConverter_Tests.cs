using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "NullToZeroConverter")]
    public class NullToZeroConverter_Tests
    {
        static string _EmptyValueString = "{ \"Value\" : \"\" }";

        static string _ValueString = " { \"Value\" : 5 } ";

        [Fact]
        public void ConvertEmptyValue()
        {
            //Normal deserialization should fail to convert null or string to int
            Assert.Throws<JsonSerializationException>(() => JsonConvert.DeserializeObject<TestObject>(_EmptyValueString));
        }

        [Fact]
        public void ConvertEmptyValueWithConverter()
        {
            //Deserializing with NullToZeroConverter should not throw exception
            var emptyValueObject = JsonConvert.DeserializeObject<TestObject>(_EmptyValueString, new NullToZeroConverter());

            Assert.Equal(emptyValueObject.Value, 0);
        }

        [Fact]
        public void ConvertWithConverter()
        {
            var valueObject = JsonConvert.DeserializeObject<TestObject>(_ValueString, new NullToZeroConverter());

            Assert.Equal(valueObject.Value, 5);
        }

        class TestObject
        {
            public int Value { get; set; }
        }
    }
}
