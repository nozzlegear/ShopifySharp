using Newtonsoft.Json;
using ShopifySharp.Infrastructure;
using System;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "InvalidDateToNullConverter"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
public class InvalidDateToNullConverter_Tests
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