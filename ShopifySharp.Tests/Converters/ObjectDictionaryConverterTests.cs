#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Converters.SystemTextJson;
using ShopifySharp.Infrastructure.Serialization.Json;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "SystemTextJson")]
[TestSubject(typeof(ObjectDictionaryConverter))]
public class ObjectDictionaryConverterTests
{
    private readonly JsonSerializerOptions _options;

    private readonly ObjectDictionaryConverter _sut;

    public ObjectDictionaryConverterTests()
    {
        _sut = new ObjectDictionaryConverter();
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
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(2)
            .And.Contain(key1, value1)
            .And.Contain(key2, value2);
    }

    [Fact]
    public void Read_WhenGivenAJsonValueThatIsNotAnObject_ShouldThrow()
    {
        // Setup
        const string json = "[]";
        var bytes = Encoding.UTF8.GetBytes(json);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            reader.Read(); // Move to the token
            return _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);
        };

        // Assert
        act.Should().Throw<JsonException>()
            .WithMessage("Expected StartObject token.");
    }

    [Fact]
    public void Read_WhenGivenAnEmptyJsonObject_ShouldReturnAnEmptyDictionary()
    {
        // Setup
        const string json = "{ }";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public void Read_WhenGivenAJsonObjectWithAnEmptyPropertyName_ShouldSkipReadingValue()
    {
        // Setup
        const string key1 = "some-key1";
        const string value1 = "some-value1";
        const string nullValue = "some-null-value";
        const string json = $$"""{ "": "{{nullValue}}", "{{key1}}": "{{value1}}" }""";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().ContainSingle(key1, value1)
            .And.NotContainValue(nullValue);
    }

    [Fact]
    public void Read_WhenGivenAJsonObjectWhereTheFirstTokenIsNotAPropertyName_ShouldThrow()
    {
        // The while loop inside the converter expects the first token type to be a PropertyName. In most cases it will
        // be, but there could be a JSON comment or other malformed json in the object.
        // Setup
        const string json =
            """
            {
              // This is a json comment
              "foo":"bar",
              "baz": "bat"
            }
            """;
        const JsonCommentHandling commentHandling = JsonCommentHandling.Allow;
        var bytes = Encoding.UTF8.GetBytes(json);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes, new JsonReaderOptions{ CommentHandling = commentHandling });
            reader.Read(); // Move to the token
            return _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);
        };

        // Assert
        act.Should().Throw<JsonException>()
            .WithMessage("Expected PropertyName token.");
    }

    [Fact]
    public void Read_WhenReadingAnySupportedType_ShouldReadAndCastToObject()
    {
        // Setup
        const string stringKey = "some-string-key";
        const string numberKey = "some-number-key";
        const string trueKey = "some-true-key";
        const string falseKey = "some-false-key";
        const string nullKey = "some-null-key";

        const string stringValue = "some-string-value";
        const int numberValue = 7;

        var json =
            //lang=json
            $$"""
            {
              "{{stringKey}}": "{{stringValue}}",
              "{{numberKey}}": {{numberValue}},
              "{{trueKey}}": true,
              "{{falseKey}}": false,
              "{{nullKey}}": null
            }
            """;
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(5)
            .And.Contain(stringKey, stringValue)
            .And.Contain(numberKey, numberValue)
            .And.Contain(trueKey, true)
            .And.Contain(falseKey, false)
            .And.Contain(nullKey, null);
    }

    [Fact]
    public void Read_WhenReadingANestedObject_ShouldRecursivelyReadAsADictionary()
    {
        // Setup
        const string key1 = "some-key1";
        const string key2 = "some-key2";
        const string value1 = "some-value1";
        const string json = $$"""{ "{{key1}}": {"{{key2}}":"{{value1}}"} }""";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(1)
            .And.ContainKey(key1)
            .WhoseValue
            .Should().BeOfType<Dictionary<string, object?>>()
            .Which
            .Should().ContainSingle(key2, value1);
    }

    [Fact]
    public void Read_WhenReadingAnUnsupportedType_ShouldReadAsSystemJsonElement()
    {
        // Setup
        const string key1 = "some-key1";
        const string value1 = "some-value1";
        const string json = $$""" { "{{key1}}": [ "{{value1}}" ] } """;
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // Move to the token

        // Act
        var result = _sut.Read(ref reader, typeof(IDictionary<string, object>), _options);

        // Assert
        result.Should().HaveCount(1)
            .And.ContainKey(key1)
            .WhoseValue
            .Should().BeOfType<SystemJsonElement>()
            .Which.GetRawText()
            .Should().Be($"""[ "{value1}" ]""");
    }

    #endregion

    #region Write

    [Fact]
    public void Write_ShouldWriteValueToJson()
    {
        Assert.Fail("Test not yet implemented");
    }

    #endregion

    #region Integration tests with a model

    private record TestModel
    {
        [JsonConverter(typeof(ObjectDictionaryConverter))]
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
        result!.Value.Should().BeEquivalentTo(new Dictionary<string, object>
        {
            {
                key1, new Dictionary<string, object>
                {
                    {key2, value1}
                }
            }
        });
    }

    [Fact]
    public void Serialize_ShouldSerializeModelToJson()
    {
        Assert.Fail("Test not yet implemented");
    }

    #endregion
}
