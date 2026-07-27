#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using Xunit;
using Serializer = ShopifySharp.Infrastructure.Serializer;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization"), TestSubject(typeof(ShopifySharp.Infrastructure.Serializer))]
public class GraphSerializerOptionsTests
{
    private static JsonSerializerOptions Opt(bool useRequest) =>
        useRequest ? Serializer.GraphRequestSerializerOptions : Serializer.GraphSerializerOptions;

    [Theory]
    [CombinatorialData]
    public void WhenSerializingInputTypeDirectly(bool useRequest)
    {
        // Setup
        var value = new AttributeInput { key = "k", @value = "v" };
        var json = JsonSerializer.Serialize(value, Opt(useRequest));

        // Act
        var doc = JsonDocument.Parse(json);

        // Assert
        doc.RootElement.TryGetProperty("__typename", out _).Should().BeFalse();
        doc.RootElement.GetProperty("key").GetString().Should().Be("k");
        doc.RootElement.GetProperty("value").GetString().Should().Be("v");
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingInputTypeFromDictionary(bool useRequest)
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "attr", new AttributeInput { key = "k", @value = "v" } },
        };

        // Act
        var json = JsonSerializer.Serialize(variables, Opt(useRequest));
        var doc = JsonDocument.Parse(json);
        var attr = doc.RootElement.GetProperty("attr");

        // Assert
        attr.TryGetProperty("__typename", out _).Should().BeFalse();
        attr.GetProperty("key").GetString().Should().Be("k");
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingInputTypeFromList(bool useRequest)
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            {
                "attrs", new List<object>
                {
                    new AttributeInput { key = "a", @value = "1" },
                    new AttributeInput { key = "b", @value = "2" },
                }
            },
        };

        // Act
        var json = JsonSerializer.Serialize(variables, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var el in doc.RootElement.GetProperty("attrs").EnumerateArray())
        {
            el.TryGetProperty("__typename", out _).Should().BeFalse();
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingStronglyTypedListOfInputType(bool useRequest)
    {
        // Setup
        var list = new List<AttributeInput>
        {
            new() { key = "a", @value = "1" },
            new() { key = "b", @value = "2" },
        };

        // Act
        var json = JsonSerializer.Serialize(list, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var el in doc.RootElement.EnumerateArray())
        {
            el.TryGetProperty("__typename", out _).Should().BeFalse();
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingDictionaryOfInputType(bool useRequest)
    {
        // Setup
        var dict = new Dictionary<string, AttributeInput>
        {
            { "a", new() { key = "k1", @value = "v1" } },
            { "b", new() { key = "k2", @value = "v2" } },
        };

        // Act
        var json = JsonSerializer.Serialize(dict, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var prop in doc.RootElement.EnumerateObject())
        {
            prop.Value.TryGetProperty("__typename", out _).Should().BeFalse();
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingListOfDictionaryOfInputType(bool useRequest)
    {
        // Setup
        var nested = new List<Dictionary<string, AttributeInput>>
        {
            new() { { "x", new() { key = "k1", @value = "v1" } } },
            new() { { "y", new() { key = "k2", @value = "v2" } } },
        };

        // Act
        var json = JsonSerializer.Serialize(nested, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var dictElem in doc.RootElement.EnumerateArray())
        foreach (var prop in dictElem.EnumerateObject())
            prop.Value.TryGetProperty("__typename", out _).Should().BeFalse();
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingListOfListOfInputType(bool useRequest)
    {
        // Setup
        var nested = new List<List<AttributeInput>>
        {
            new() { new() { key = "a", @value = "1" } },
            new() { new() { key = "b", @value = "2" }, new() { key = "c", @value = "3" } },
        };

        // Act
        var json = JsonSerializer.Serialize(nested, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var listElem in doc.RootElement.EnumerateArray())
        foreach (var el in listElem.EnumerateArray())
            el.TryGetProperty("__typename", out _).Should().BeFalse();
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingDictionaryOfInterfaceType(bool useRequest)
    {
        // Setup
        var dict = new Dictionary<string, INode>
        {
            { "a", new Metaobject { handle = "h1" } },
            { "b", new Metaobject { handle = "h2" } },
        };

        // Act
        var json = JsonSerializer.Serialize(dict, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // GraphRequestSerializerOptions suppresses __typename for all types
        // GraphSerializerOptions preserves __typename for interface types

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var prop in doc.RootElement.EnumerateObject())
        {
            prop.Value.TryGetProperty("__typename", out _).Should().Be(!useRequest);
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingInterfaceTypeDirectly(bool useRequest)
    {
        // Setup
        INode value = new Metaobject { handle = "h" };

        // Act
        var json = JsonSerializer.Serialize(value, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        //
        // GraphRequestSerializerOptions suppresses __typename for all types
        // GraphSerializerOptions preserves __typename for interface types
        doc.RootElement.TryGetProperty("__typename", out _).Should().Be(!useRequest);

        // TODO: use .ShouldAllSatisfy
        if (!useRequest)
        {
            doc.RootElement.GetProperty("handle").GetString().Should().Be("h");
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingNonInputTypeFromDictionary(bool useRequest)
    {
        // Setup
        var dict = new Dictionary<string, object>
        {
            { "node", new Metaobject { handle = "n1" } },
        };

        // Act
        var json = JsonSerializer.Serialize(dict, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // GraphRequestSerializerOptions suppresses __typename for all types
        // GraphSerializerOptions preserves __typename for polymorphic types (even when boxed as object)
        // Assert
        doc.RootElement.GetProperty("node").TryGetProperty("__typename", out _).Should().Be(!useRequest);

        doc.RootElement.GetProperty("node").GetProperty("handle").GetString().Should().Be("n1");
    }

    [Fact]
    public void WhenSerializingNonInputTypeFromList()
    {
        // Setup
        var list = new List<object>
        {
            new Metaobject { handle = "n1" },
            new Metaobject { handle = "n2" },
        };
        var variables = new Dictionary<string, object> { { "nodes", list } };

        // Act
        var json = JsonSerializer.Serialize(variables, Opt(true));
        var doc = JsonDocument.Parse(json);
        var nodeArray = doc.RootElement.GetProperty("nodes");

        // Assert
        // TODO: use .ShouldAllSatisfy
        foreach (var node in nodeArray.EnumerateArray())
        {
            node.TryGetProperty("__typename", out _).Should().BeFalse();
            node.GetProperty("handle").GetString().Should().StartWith("n");
        }
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingConcreteTypeDirectly(bool useRequest)
    {
        // Setup
        var value = new Metaobject { handle = "h" };

        // Act
        var json = JsonSerializer.Serialize(value, Opt(useRequest));
        var doc = JsonDocument.Parse(json);

        // Assert
        // GraphRequestSerializerOptions suppresses __typename for all types
        // GraphSerializerOptions suppresses __typename for concrete types (no polymorphism)
        doc.RootElement.TryGetProperty("__typename", out _).Should().BeFalse();
        doc.RootElement.GetProperty("handle").GetString().Should().Be("h");
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingNestedObject(bool useRequest)
    {
        // Setup
        var nested = new Dictionary<string, object>
        {
            {
                "outer", new Dictionary<string, object>
                {
                    { "inner", new Metaobject { handle = "h" } },
                }
            },
        };

        // Act
        var json = JsonSerializer.Serialize(nested, Opt(useRequest));
        var doc = JsonDocument.Parse(json);
        var inner = doc.RootElement.GetProperty("outer").GetProperty("inner");

        // Assert
        // GraphRequestSerializerOptions suppresses __typename for all types
        // GraphSerializerOptions preserves __typename for polymorphic types (even when nested)
        inner.TryGetProperty("__typename", out _).Should().Be(!useRequest);
    }

    [Theory]
    [CombinatorialData]
    public void WhenSerializingObjectWithNullProperties_ShouldOmitThem(bool useRequest)
    {
        // Setup
        var input = new AttributeInput { key = "k" }; // @value is null
        var json = JsonSerializer.Serialize(input, Opt(useRequest));

        // Act
        var doc = JsonDocument.Parse(json);

        // Assert
        // Null properties should be omitted due to DefaultIgnoreCondition.WhenWritingNull
        doc.RootElement.TryGetProperty("value", out _).Should().BeFalse("Null properties should be omitted during serialization");
    }

    [Fact]
    public void GraphSerializerOptions_WhenCreated_ShouldHaveTypeInfoResolverConfigured()
    {
        // Assert the resolver is set
        Serializer.GraphSerializerOptions.TypeInfoResolver.Should().NotBeNull("TypeInfoResolver should be configured");
        Serializer.GraphSerializerOptions.TypeInfoResolver.GetType().Should().Be<DefaultJsonTypeInfoResolver>();
    }

    [Fact]
    public void GraphSerializerOptions_WhenCreated_ShouldHaveCorrectDefaults()
    {
        // Assert the full configuration of GraphSerializerOptions
        Serializer.GraphSerializerOptions.PropertyNamingPolicy.Should().Be(JsonNamingPolicy.CamelCase);
        Serializer.GraphSerializerOptions.DefaultIgnoreCondition.Should().Be(JsonIgnoreCondition.WhenWritingNull);
        Serializer.GraphSerializerOptions.NumberHandling.Should().Be(JsonNumberHandling.AllowReadingFromString);
    }
}
