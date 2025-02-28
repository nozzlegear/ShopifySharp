#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Converters.SystemTextJson;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "SystemTextJson")]
[TestSubject(typeof(GraphErrorExtensionsValueConverter))]
public class GraphErrorExtensionsValueConverterTests
{
    private const string DictionaryKey = "$value";

    private readonly JsonSerializerOptions _options;

    private readonly GraphErrorExtensionsValueConverter _sut;

    public GraphErrorExtensionsValueConverterTests()
    {
        _sut = new GraphErrorExtensionsValueConverter();
        _options = new JsonSerializerOptions();
        _options.Converters.Add(_sut);
    }

    #region Read

    [Fact]
    public void Read_WhenGivenAJsonObject_ShouldReadToDictionary()
    {
        // Setup
        const string key1 = "some-key1";
        const string value1 = "some-value1";
        const string key2 = "some-key2";
        const string value2 = "some-value2";
        const string json = $$"""{"{{key1}}": "{{value1}}", "{{key2}}":"{{value2}}"}""";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(2)
            .And.Contain(key1, value1)
            .And.Contain(key2, value2);
    }

    [Theory]
    [InlineData("\"some-value1\"", "some-value1")]
    [InlineData("123", 123)]
    [InlineData("true", true)]
    [InlineData("false", false)]
    [InlineData("null", null)]
    public void Read_WhenGivenAPrimitiveValue_ShouldReadToDictionaryWithValueKey(string jsonValue, object? expectedValue)
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes(jsonValue);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(1)
            .And.Contain(DictionaryKey, expectedValue);
    }

    [Fact]
    public void Read_WhenGivenAnUnsupportedJsonValueType_ShouldThrow()
    {
        // Setup
        const string jsonValue = "[]";
        var bytes = Encoding.UTF8.GetBytes(jsonValue);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            reader.Read();
            return _sut.Read(ref reader, typeof(IDictionary<string, object?>), _options);
        };

        // Assert
        act.Should().Throw<JsonException>()
            .WithMessage("Unexpected token StartArray when mapping a GraphErrorExtensionsValue object.");
    }

    #endregion

    #region Integration tests using a model

    private record TestModel
    {
        [JsonConverter(typeof(GraphErrorExtensionsValueConverter))]
        public IReadOnlyDictionary<string, object?> Value { get; set; } = null!;
    }

    [Fact]
    public void Deserialize_WhenGivenAnUnnestedValueObject_ShouldReadToDictionary()
    {
        // Setup
        const string key1 = "some-key1";
        const string value1 = "some-value1";
        const string key2 = "some-key2";
        const string value2 = "some-value2";
        const string json = $$$"""{"Value": {"{{{key1}}}": "{{{value1}}}", "{{{key2}}}":"{{{value2}}}"}}""";

        // Act
        var result = JsonSerializer.Deserialize<TestModel>(json, _options);

        // Assert
        result!.Value.Should().BeEquivalentTo([
            new KeyValuePair<string, object>(key1, value1),
            new KeyValuePair<string, object>(key2, value2),
        ]);
    }

    [Fact]
    public void Deserialize_WhenGivenANestedValueObject_ShouldReadToDictionary()
    {
        // Setup
        const string key1 = "some-key1";
        const string key2 = "some-key2";
        const string value1 = "some-value1";
        const string json = $$""" {"Value": {"{{key1}}": {"{{key2}}":"{{value1}}"} } } """;

        // Act
        var result = JsonSerializer.Deserialize<TestModel>(json, _options);

        // Assert
        result!.Value
            .Should().HaveCount(1)
            .And.ContainKey(key1)
            .WhoseValue
            .Should().BeAssignableTo<Dictionary<string, object>>()
            .Which
            .Should().HaveCount(1)
            .And.Contain(key2, value1);
    }

    [Theory]
    [InlineData("\"some-value1\"", "some-value1")]
    [InlineData("123", 123)]
    [InlineData("true", true)]
    [InlineData("false", false)]
    public void Deserialize_WhenGivenAPrimitiveValue_ShouldReadToDictionaryWithValueKey(string jsonValue, object? expectedValue)
    {
        // Setup
        var json = $$"""{"Value":{{jsonValue}}}""";

        // Act
        var result = JsonSerializer.Deserialize<TestModel>(json, _options);

        // Assert
        result!.Value
            .Should().HaveCount(1)
            .And.Contain(DictionaryKey, expectedValue);
    }

    [Fact]
    public void Serialize_ShouldThrow()
    {
        // Setup
        var value = new TestModel { Value = new Dictionary<string, object?>() };

        // Act
        var act = () => JsonSerializer.Serialize(value, _options);

        // Assert
        act.Should().Throw<NotSupportedException>();
    }

    #endregion
}
