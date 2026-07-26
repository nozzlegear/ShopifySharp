#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization"), TestSubject(typeof(ShopifySharp.Infrastructure.Serializer))]
public class GraphSerializerOptionsTests
{
    private readonly JsonSerializerOptions _options = ShopifySharp.Infrastructure.Serializer.GraphSerializerOptions;

    [Fact]
    public void GraphSerializerOptions_WhenSerializingConcretePolymorphicType_ShouldNotEmitTypename()
    {
        // Setup
        // Metaobject implements INode, which has the JsonPolymorphic `__typename` discriminator
        var metaobject = new Metaobject()
        {
            handle = "test-handle",
            fields = [new MetaobjectField() { key = "key1", value = "value1" }],
        };

        // Act
        var json = JsonSerializer.Serialize(metaobject, _options);

        // Assert
        var doc = JsonDocument.Parse(json);
        doc.RootElement.TryGetProperty("__typename", out _).Should().BeFalse("Polymorphic types should not emit __typename during serialization");
        doc.RootElement.TryGetProperty("handle", out var handle).Should().BeTrue();
        handle.GetString().Should().Be("test-handle");
    }

    [Fact]
    public void GraphSerializerOptions_WhenSerializingObjectFromDictionary_ShouldNotEmitTypename()
    {
        // Setup
        // Concrete type stored as object in dictionary (simulates GraphQL variables)
        var metaobject = new Metaobject()
        {
            handle = "test-handle",
            fields = [new MetaobjectField() { key = "key1", value = "value1" }],
        };
        var variables = new Dictionary<string, object>
        {
            { "metaobject", metaobject },
        };

        // Act
        var json = JsonSerializer.Serialize(variables, _options);

        // Assert
        var doc = JsonDocument.Parse(json);
        var metaobj = doc.RootElement.GetProperty("metaobject");
        metaobj.TryGetProperty("__typename", out _).Should().BeFalse("object type values should not emit __typename during serialization");
        metaobj.TryGetProperty("handle", out var handle).Should().BeTrue();
        handle.GetString().Should().Be("test-handle");
    }

    [Fact]
    public void GraphSerializerOptions_WhenSerializingNestedObject_ShouldNotEmitTypename()
    {
        // Setup
        // Nested polymorphic values
        var metaobject = new Metaobject()
        {
            handle = "test-handle",
            fields = [new MetaobjectField() { key = "key1", value = "value1" }],
        };
        var nested = new Dictionary<string, object>
        {
            { "outer", new Dictionary<string, object> { { "inner", metaobject } } },
        };

        // Act
        var json = JsonSerializer.Serialize(nested, _options);

        // Assert
        var doc = JsonDocument.Parse(json);
        var inner = doc.RootElement.GetProperty("outer").GetProperty("inner");
        inner.TryGetProperty("__typename", out _).Should().BeFalse("Nested polymorphic entities should not emit __typename during serialization");
    }

    [Fact]
    public void GraphSerializerOptions_WhenSerializingNullValueInDictionary_ShouldEmitJsonNull()
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "nullable", null! },
        };

        // Act
        var json = JsonSerializer.Serialize(variables, _options);

        // Assert
        var doc = JsonDocument.Parse(json);
        doc.RootElement.GetProperty("nullable").ValueKind.Should().Be(JsonValueKind.Null);
    }

    [Fact]
    public void GraphSerializerOptions_WhenDeserializingConcreteType_ShouldPopulateAllProperties()
    {
        // Setup
        const string json = """{"handle":"test-handle","type":"custom-type"}""";

        // Act
        var result = JsonSerializer.Deserialize<Metaobject>(json, _options);

        // Assert
        result.Should().NotBeNull();
        result!.handle.Should().Be("test-handle");
        result.type.Should().Be("custom-type");
    }

    [Fact]
    public void GraphSerializerOptions_WhenRoundTripping_ShouldPreserveAllValues()
    {
        // Setup
        var original = new Metaobject()
        {
            handle = "round-trip-handle",
            type = "round-trip-type",
        };

        // Act
        var json = JsonSerializer.Serialize(original, _options);
        var deserialized = JsonSerializer.Deserialize<Metaobject>(json, _options);

        // Assert
        deserialized.Should().NotBeNull();
        deserialized!.handle.Should().Be(original.handle);
        deserialized.type.Should().Be(original.type);
    }

    [Fact]
    public void GraphSerializerOptions_WhenSerializingObjectWithNullProperties_ShouldOmitThem()
    {
        // Setup
        // Metaobject with some null fields
        var metaobject = new Metaobject()
        {
            handle = "test-handle",
            // type is null by default
        };

        // Act
        var json = JsonSerializer.Serialize(metaobject, _options);

        // Assert
        var doc = JsonDocument.Parse(json);
        doc.RootElement.TryGetProperty("handle", out _).Should().BeTrue();
        // Null properties should be omitted due to DefaultIgnoreCondition.WhenWritingNull
        doc.RootElement.TryGetProperty("type", out _).Should().BeFalse("Null properties should be omitted during serialization");
    }

    [Fact]
    public void GraphSerializerOptions_WhenCreated_ShouldHaveTypeInfoResolverConfigured()
    {
        // Assert the resolver is set
        _options.TypeInfoResolver.Should().NotBeNull("TypeInfoResolver should be configured");
        _options.TypeInfoResolver.GetType().Should().Be<DefaultJsonTypeInfoResolver>();
    }

    [Fact]
    public void GraphSerializerOptions_WhenCreated_ShouldHaveCorrectDefaults()
    {
        // Assert the full configuration of GraphSerializerOptions
        _options.NumberHandling.Should().Be(JsonNumberHandling.AllowReadingFromString);
        _options.PropertyNamingPolicy.Should().Be(JsonNamingPolicy.CamelCase);
        // DefaultIgnoreCondition is not directly accessible on JsonSerializerOptions,
        // but we verify its behavior in this test suite's null behavior tests
    }

    [Fact]
    public void GraphSerializerOptions_WhenCreated_ShouldIncludeJsonStringEnumConverter()
    {
        // Assert the enum converter is present
        _options.Converters.Should().ContainSingle(c => c is JsonStringEnumConverter);
    }
}