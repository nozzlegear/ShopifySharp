using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Parameterizable"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
public class ParameterizableTests
{
    class TestFilter : Parameterizable
    {
        public IEnumerable<string> StringListProp { get; set; }
            
        public IEnumerable<long> LongListProp { get; set; }
            
        public int? IntProp { get; set; }
            
        public long? LongProp { get; set; }
            
        public string StringProp { get; set; }
            
        public bool? BoolProp { get; set; }
            
        [JsonProperty("foo_prop")]
        public int? PropWithJsonName { get; set; }
    }

    [Fact]
    public void Should_Serialize_String_Array()
    {
        var filter = new TestFilter
        {
            StringListProp = new[] {"foo", "bar", "baz"}
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("StringListProp", kvp.Key);
        Assert.Equal("foo,bar,baz", kvp.Value);
    }

    [Fact]
    public void Should_Serialize_Long_Array()
    {
        var filter = new TestFilter
        {
            LongListProp = new[] {5L,6,7,8}
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("LongListProp", kvp.Key);
        Assert.Equal("5,6,7,8", kvp.Value);
    }

    [Fact]
    public void Should_Serialize_Int_Prop()
    {
        var filter = new TestFilter
        {
            IntProp = 20
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("IntProp", kvp.Key);
        Assert.Equal(20, kvp.Value);
    }

    [Fact]
    public void Should_Serialize_Long_Prop()
    {
        var filter = new TestFilter
        {
            LongProp = 30
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("LongProp", kvp.Key);
        Assert.Equal(30L, kvp.Value);
    }

    [Fact]
    public void Should_Serialize_String_Prop()
    {
        var filter = new TestFilter
        {
            StringProp = "foo"
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("StringProp", kvp.Key);
        Assert.Equal("foo", kvp.Value);
    }

    [Fact]
    public void Should_Serialize_Bool_Prop()
    {
        var filter = new TestFilter
        {
            BoolProp = false
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("BoolProp", kvp.Key);
        Assert.Equal(false, kvp.Value);
    }

    [Fact]
    public void Should_Use_Property_Name_From_Json_Attribute_When_Available()
    {
        var filter = new TestFilter
        {
            PropWithJsonName = 25
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Single(result);

        var kvp = result.First();
            
        Assert.Equal("foo_prop", kvp.Key);
        Assert.Equal(25, kvp.Value);
    }
        
    [Fact]
    public void Should_Serialize_Multiple_Props()
    {
        var filter = new TestFilter
        {
            PropWithJsonName = 25,
            StringListProp = new[] {"hello", "world"}
        };
        var result = filter.ToQueryParameters().ToList();

        Assert.Equal(2, result.Count());

        var first = result.First();
            
        Assert.Equal("StringListProp", first.Key);
        Assert.Equal("hello,world", first.Value);

        var second = result.Last();
            
        Assert.Equal("foo_prop", second.Key);
        Assert.Equal(25, second.Value);
    }
}