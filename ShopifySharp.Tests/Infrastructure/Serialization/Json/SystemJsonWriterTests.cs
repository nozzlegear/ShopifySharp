using System.Buffers;
using System.Text.Json;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure.Serialization.Json;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization"), TestSubject(typeof(SystemJsonWriter))]
public class SystemJsonWriterTests
{
    private readonly MemoryStream _stream;
    private readonly Utf8JsonWriter _jsonWriter;

    private readonly SystemJsonWriter _sut;

    public SystemJsonWriterTests()
    {
        _stream = new MemoryStream();
        _jsonWriter = new Utf8JsonWriter(_stream);
        _sut = new SystemJsonWriter(_jsonWriter);
    }

    #region Writer (underlying Utf8JsonWriter)

    [Fact]
    public void Writer_AccessingField_ShouldReturnUnderlyingUtf8JsonWriter()
    {
        // Assert
        _sut.Writer.Should().BeSameAs(_jsonWriter);
    }

    #endregion

    #region WriteNullValue

    [Fact]
    public async Task WriteNullValue_ShouldWriteNullValueToUnderlyingUtf8JsonWriter()
    {
        // Setup
        const string expectedJson = "null";

        // Act
        _sut.WriteNullValue();
        await _jsonWriter.FlushAsync();

        // Assert
        _stream.Position = 0;

        using var streamReader = new StreamReader(_stream);
        var json = await streamReader.ReadToEndAsync();

        json.Should().Be(expectedJson, "the writer should write the literal string \"{0}\" to the stream", expectedJson);
    }

    #endregion
}
