using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Converters;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "NewtonsoftJson")]
[TestSubject(typeof(FalseToNullConverter))]
public class FalseToNullConverterTests
{
    [Fact]
    public void SerializeChargeTest()
    {
        var charge = Serializer.Deserialize<RecurringCharge>("{ \"test\" : true }");
        Assert.True(charge.Test);

        charge = Serializer.Deserialize<RecurringCharge>("{ \"test\" : null }");
        Assert.False(charge.Test);
            
        charge = Serializer.Deserialize<RecurringCharge>("{ \"test\" : false }");
        Assert.False(charge.Test);

        Assert.True(JObject.Parse(Serializer.Serialize(new RecurringCharge { Test = true })).Value<bool?>("test"));

        Assert.Null(JObject.Parse(Serializer.Serialize(new RecurringCharge { Test = false })).Value<bool?>("test"));

        Assert.Null(JObject.Parse(Serializer.Serialize(new RecurringCharge { Test = null })).Value<bool?>("test"));
    }

    [Fact]
    public void SerializeTrue()
    {
        string serializedJson = JsonConvert.SerializeObject(new TestObject()
        {
            Value = true
        }, new FalseToNullConverter());
        var deserialized = JsonConvert.DeserializeObject<TestObject>("{ \"Value\" : \"true\" }", new FalseToNullConverter());

        Assert.Equal("{\"Value\":true}", serializedJson);
        Assert.True(deserialized.Value);
    }

    [Fact]
    public void SerializeFalse()
    {
        string serializedJson = JsonConvert.SerializeObject(new TestObject()
        {
            Value = false
        }, new FalseToNullConverter());
        var deserialized = JsonConvert.DeserializeObject<TestObject>("{ \"Value\" : \"\" }", new FalseToNullConverter());

        Assert.Equal("{\"Value\":null}", serializedJson);
        Assert.False(deserialized.Value);
    }

    class TestObject
    {
        public bool Value { get; set; }
    }
}
