using System;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using ShopifySharp.Converters;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "NewtonsoftJson")]
[TestSubject(typeof(InvalidDateConverter))]
public class InvalidDateConverterTests
{
    private readonly JsonSerializer _serializer = new();
    private readonly JsonTextReader _jsonReader = A.Fake<JsonTextReader>(x => x.Strict());

    private readonly InvalidDateConverter _sut = new();

    #region ReadJson

    [Fact]
    public void ReadJson_WhenReadingMalformedDate_ShouldReturnNull()
    {
        // Setup
        const string json = "0000-12-31T18:09:24-05:50";

        A.CallTo(() => _jsonReader.Value).Returns(json);
        A.CallTo(() => _jsonReader.TokenType).Returns(JsonToken.String);

        // Act
        var result = _sut.ReadJson(_jsonReader, typeof(DateTime?), null, _serializer);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void ReadJson_WhenReadingValidDate_ShouldReturnParsedDate()
    {
        // Setup
        const string json = "2021-05-01T12:00:00Z";

        A.CallTo(() => _jsonReader.Value).Returns(json);
        A.CallTo(() => _jsonReader.TokenType).Returns(JsonToken.String);

        // Act
        var result = _sut.ReadJson(_jsonReader, typeof(DateTime?), null, _serializer);

        // Assert
        result.Should().NotBeNull()
            .And.BeOfType<DateTime>()
            // The ISO date "2021-05-01T12:00:00Z" is parsed as UTC.
            .Which.Should().Be(new DateTime(2021, 5, 1, 12, 0, 0, DateTimeKind.Utc));
    }

    [Fact]
    public void ReadJson_WhenReadingNull_ShouldReturnNull()
    {
        // Setup
        const string json = "null";

        A.CallTo(() => _jsonReader.Value).Returns(json);
        A.CallTo(() => _jsonReader.TokenType).Returns(JsonToken.Null);

        // Act
        var result = _sut.ReadJson(_jsonReader, typeof(DateTime?), null, _serializer);

        // Assert
        result.Should().BeNull();
    }

    #endregion

    #region Deserialization tests using a model

    public class TestModel
    {
        [JsonConverter(typeof(InvalidDateConverter))]
        public DateTime? Date { get; set; }
    }

    [Fact]
    public void Deserialization_WhenGivenADateThatIsMalformed_ShouldOutputNull()
    {
        // Setup
        const string json = "{ \"Date\": \"0000-12-31T18:09:24-05:50\" }";

        // Act
        var model = JsonConvert.DeserializeObject<TestModel>(json);

        // Assert
        model.Should().NotBeNull();
        model.Date.Should().BeNull();
    }

    [Fact]
    public void Deserialization_WhenGivenAValidDate_ShouldOutputDate()
    {
        // Setup
        const string json = "{ \"Date\": \"2021-05-01T12:00:00Z\" }";

        // Act
        var model = JsonConvert.DeserializeObject<TestModel>(json);

        // Assert
        model.Should().NotBeNull();
        model.Date.Should().Be(new DateTime(2021, 5, 1, 12, 0, 0, DateTimeKind.Utc));
    }

    #endregion
}
