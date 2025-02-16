using System;
using System.Collections.Generic;
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
[TestSubject(typeof(PrimitiveStringListConverter<>))]
public class PrimitiveStringListConverterTests
{
    private readonly JsonSerializerOptions _options;
    private readonly PrimitiveStringListConverter<IEnumerable<string>> _converter;

    public PrimitiveStringListConverterTests()
    {
        _options = new JsonSerializerOptions();
        _options.Converters.Add(new PrimitiveStringConverter());
        _converter = new PrimitiveStringListConverter<IEnumerable<string>>(_options);
    }

    #region Read

    [Fact]
    public void Read_ShouldReadValuesToAnIEnumerable()
    {
        // Setup
        const string json = "[\"hello\", \"world\"]";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read(); // moves to StartArray

        // Act
        var result = _converter.Read(ref reader, typeof(IEnumerable<string>), _options);

        // Assert
        result.Should().BeEquivalentTo(["hello", "world"]);
    }

    [Fact]
    public void Read_WhenJsonArrayContainsNumberBooleanAndNullValues_ShouldSkipNullValuesAndReadAllOtherValuesAsStrings()
    {
        // Setup
        const string json = "[\"hello\", 123, true, null, false, true]";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var result = _converter.Read(ref reader, typeof(IEnumerable<string>), _options);

        // Assert
        // Null values should be skipped and not read by the converter
        result.Should().BeEquivalentTo(["hello", "123", "True", "False", "True"]);
    }


    [Fact]
    public void Read_ShouldReadValuesToAnIReadOnlyList()
    {
        // Setup
        const string json = "[\"hello\", 42]";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        var converter = new PrimitiveStringListConverter<IReadOnlyList<string>>(_options);
        reader.Read();

        // Act
        var result = converter.Read(ref reader, typeof(IReadOnlyList<string>), _options);

        // Assert
        result.Should().BeEquivalentTo("hello", "42");
        // Also check that the list is read-only.
        // The converter returns a ReadOnlyCollection<string>, which implements IList<string> with IsReadOnly true.
        var asList = result as IList<string>;
        asList.Should().NotBeNull();
        asList!.IsReadOnly.Should().BeTrue();
    }

    [Fact]
    public void Read_WhenGivenANonJsonArrayValue_ShouldThrowJsonException()
    {
        // Setup
        const string json = """{"foo":"bar"}""";
        var bytes = Encoding.UTF8.GetBytes(json);

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            reader.Read();
            _converter.Read(ref reader, typeof(IEnumerable<string>), _options);
        };

        // Assert
        act.Should().Throw<JsonException>();
    }

    [Fact]
    public void Read_WhenGivenAnUnsupportedConversionType_ShouldThrowArgumentException()
    {
        // Setup
        // The converter only supports typeToConvert exactly equal to IEnumerable<string> or IReadOnlyList<string>.
        // Using e.g. List<string> is not supported.
        const string json = """["hello"]""";
        var bytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(bytes);
        reader.Read();

        // Act
        var act = () =>
        {
            var reader = new Utf8JsonReader(bytes);
            var converter = new PrimitiveStringListConverter<List<string>>(_options);
            reader.Read();
            converter.Read(ref reader, typeof(List<string>), _options);
        };

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    #endregion

    #region Write

    [Fact]
    public void Write_WhenGivenANonEmptyCollection_ShouldWriteJsonArray()
    {
        // Setup
        var collection = new List<string> { "hello", "123", "True" };
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _converter.Write(writer, collection, _options);
        writer.Flush();
        var json = Encoding.UTF8.GetString(stream.ToArray());

        // Assert
        json.Should().Be("""["hello","123","True"]""");
    }

    [Fact]
    public void Write_WhenGivenAnEmptyCollection_ShouldWriteEmptyJsonArray()
    {
        // Setup
        string[] collection = [];
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _converter.Write(writer, collection, _options);
        writer.Flush();
        var json = Encoding.UTF8.GetString(stream.ToArray());

        // Assert
        json.Should().Be("[]");
    }

    [Fact]
    public void Write_WhenGivenACollectionWithNullElements_ShouldWriteNulls()
    {
        // Setup
        var collection = new List<string> { "hello", null, "world" };
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        // Act
        _converter.Write(writer, collection, _options);
        writer.Flush();
        var json = Encoding.UTF8.GetString(stream.ToArray());

        // Assert
        json.Should().Be("""["hello",null,"world"]""");
    }

    #endregion
}
