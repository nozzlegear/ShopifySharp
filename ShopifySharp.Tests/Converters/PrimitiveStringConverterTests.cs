using System.IO;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Converters.SystemTextJson;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "SystemTextJson")]
[TestSubject(typeof(PrimitiveStringConverter))]
public class PrimitiveStringConverterTests
{
    private readonly JsonSerializerOptions _options;
    private readonly PrimitiveStringConverter _converter;

    public PrimitiveStringConverterTests()
    {
        _converter = new PrimitiveStringConverter();
        _options = new JsonSerializerOptions();
        _options.Converters.Add(_converter);
    }

    #region Read

    [Fact]
    public void Read_WhenGivenAJsonString_ShouldReturnString()
    {
        // Setup
        const string json = "\"hello\"";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        // Move to the token
        reader.Read();

        // Act
        var result = _converter.Read(ref reader, typeof(string), _options);

        // Assert
        result.Should().Be("hello");
    }

    [Fact]
    public void Read_WhenGivenAJsonNumber_ShouldReturnString()
    {
        // Setup
        const string json = "123";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _converter.Read(ref reader, typeof(string), _options);

        // Assert
        result.Should().Be("123");
    }

    [Theory]
    [InlineData("true", "True")]
    [InlineData("false", "False")]
    public void Read_WhenGivenAJsonBoolean_ShouldReturnString(string json, string expected)
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _converter.Read(ref reader, typeof(string), _options);

        // Assert
        result.Should().Be(expected, "the result should match expected value \"{0}\"", expected);
    }

    [Fact]
    public void Read_WhenGivenAJsonNull_ShouldReturnNull()
    {
        // Setup
        var json = "null";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _converter.Read(ref reader, typeof(string), _options);

        // Assert
        Assert.Null(result);
    }

    [Theory]
    [InlineData("[1, 2, 3]")]
    [InlineData("{\"foo\": \"bar\"")]
    public void Read_WhenGivenAnUnsupportedJsonTokenType_ShouldThrowJsonException(string json)
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes(json);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            reader.Read(); // This should be StartArray
            _converter.Read(ref reader, typeof(string), _options);
        };

        // Assert
        act.Should().Throw<JsonException>();
    }

    #endregion

    #region Write

    [Fact]
    public void Write_WhenGivenANonNullString_ShouldWriteStringValue()
    {
        // Setup
        const string expectedValue = "hello";
        var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _converter.Write(writer, expectedValue, _options);
        writer.Flush();
        var json = Encoding.UTF8.GetString(stream.ToArray());

        // Assert
        json.Should().Be($"\"{expectedValue}\"");
    }

    [Fact]
    public void Write_WhenGivenANullValue_ShouldWriteNullValue()
    {
        // Setup
        var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            // Act
            _converter.Write(writer, null, _options);
            writer.Flush();
        }
        var json = Encoding.UTF8.GetString(stream.ToArray());

        // Assert
        json.Should().Be("null");
    }

    #endregion
}
