using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using ShopifySharp.Converters;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "NewtonsoftJson")]
[TestSubject(typeof(InvalidDateConverter))]
public class InvalidDateConverterTests
{
    [Fact]
    public void SerializeRoundtripValidDates()
    {
        DateTime validNow = DateTime.Now;
        DateTimeOffset validNowOffset = DateTimeOffset.Now;

        string serializedJson = Serializer.Serialize(new TestObject
        {
            DateTime = validNow,
            DateTimeOffset = validNowOffset
        });
        var deserialized = Serializer.Deserialize<TestObject>(serializedJson);

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
        }).Replace("null", strInvalidISODate);

        var deserialized = Serializer.Deserialize<TestObject>(serializedJson);

        Assert.Null(deserialized.DateTime);
        Assert.Null(deserialized.DateTimeOffset);
    }

    class TestObject
    {
        public DateTime? DateTime { get; set; }
        public DateTimeOffset? DateTimeOffset { get; set; }
    }
}
