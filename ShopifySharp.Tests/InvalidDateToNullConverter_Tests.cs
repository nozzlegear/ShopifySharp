using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "InvalidDateToNullConverter")]
    public class InvalidDateToNullConverter_Tests
    {
        [Fact]
        public void SerializeRoundtripValidDates()
        {
            DateTime validNow = DateTime.Now;
            DateTimeOffset validNowOffset = DateTimeOffset.Now;

            string serializedJson = JsonConvert.SerializeObject(new TestObject()
                                                                    {
                                                                        DateTime = validNow,
                                                                        DateTimeOffset = validNowOffset,
                                                                    }, new InvalidDateToNullConverter());
            var deserialized = JsonConvert.DeserializeObject<TestObject>(serializedJson, new InvalidDateToNullConverter());

            Assert.Equal(validNow, deserialized.DateTime);
            Assert.Equal(validNowOffset, deserialized.DateTimeOffset);
        }

        [Fact]
        public void SerializeRoundtripInvalidDates()
        {
            string strInvalidISODate = "\"0000-12-31T18:09:24+01:00\"";
            string serializedJson = JsonConvert.SerializeObject(new TestObject()
                                                {
                                                    DateTime = null,
                                                    DateTimeOffset = null,
                                                }, new InvalidDateToNullConverter())
                                                .Replace("null", strInvalidISODate);

            var deserialized = JsonConvert.DeserializeObject<TestObject>(serializedJson, new InvalidDateToNullConverter());

            Assert.Equal(null, deserialized.DateTime);
            Assert.Equal(null, deserialized.DateTimeOffset);
        }

        class TestObject
        {
            public DateTime? DateTime { get; set; }
            public DateTimeOffset? DateTimeOffset { get; set; }
        }
    }
}
