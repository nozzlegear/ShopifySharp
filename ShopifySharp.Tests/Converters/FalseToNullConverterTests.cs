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
[TestSubject(typeof(FalseToNullConverter))]
public class FalseToNullConverterTests
{
    private readonly JsonSerializer _serializer = new();
    private readonly JsonTextWriter _jsonWriter = A.Fake<JsonTextWriter>(x => x.Strict());
    private readonly JsonTextReader _jsonReader = A.Fake<JsonTextReader>(x => x.Strict());

    public FalseToNullConverterTests()
    {
        A.CallTo(() => _jsonWriter.WriteNull()).DoesNothing();
        A.CallTo(() => _jsonWriter.WriteValue(A<bool>._)).DoesNothing();
    }

    private readonly FalseToNullConverter _sut = new();

    #region CanConvert

    [Theory]
    [InlineData(typeof(string), true)]
    [InlineData(typeof(bool), true)]
    [InlineData(typeof(bool?), true)]
    [InlineData(typeof(int), false)]
    [InlineData(typeof(string[]), false)]
    public void CanConvert_WhenGivenASupportedType_ShouldReturnTrue(Type typeToConvert, bool shouldPass)
    {
        // Act
        var result = _sut.CanConvert(typeToConvert);

        // Assert
        if (shouldPass)
            result.Should().BeTrue("the type {0} is supported by the factory", typeToConvert);
        else
            result.Should().BeFalse("the type {0} is not supported by the factory", typeToConvert);
    }

    #endregion

    #region ReadJson

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ReadJson_WhenGivenANullOrEmptyString_ShouldReturnFalse(string valueToRead)
    {
        // Setup
        A.CallTo(() => _jsonReader.Value).Returns(valueToRead);

        // Act
        var result = _sut.ReadJson(_jsonReader, typeof(bool), valueToRead, _serializer);

        // Assert
        result.Should().BeOfType<bool>()
            .Which
            .Should().BeFalse();
    }

    [Theory]
    [InlineData("true", true)]
    [InlineData("True", true)]
    [InlineData("TRUE", true)]
    [InlineData("trUE", true)]
    [InlineData("false", false)]
    [InlineData("False", false)]
    [InlineData("FALSE", false)]
    [InlineData("faLSE", false)]
    public void ReadJson_WhenGivenABooleanValueString_ShouldParseAndReturnABoolean(string valueToRead, bool expectedOutput)
    {
        // Setup
        A.CallTo(() => _jsonReader.Value).Returns(valueToRead);

        // Act
        var result = _sut.ReadJson(_jsonReader, typeof(bool), valueToRead, _serializer);

        // Assert
        result.Should().BeOfType<bool>()
            .Which
            .Should().Be(expectedOutput, "the parsed boolean should match the expected boolean value");
    }

    [Theory]
    [InlineData("123")]
    [InlineData("{}")]
    [InlineData("['hello', 'world']")]
    [InlineData("undefined")]
    public void ReadJson_WhenGivenAValueOfAnUnsupportedType_ShouldParseAndReturnABoolean(string valueToRead)
    {
        // Setup
        A.CallTo(() => _jsonReader.Value).Returns(valueToRead);

        // Act
        var act = () => _sut.ReadJson(_jsonReader, typeof(bool), valueToRead, _serializer);

        // Assert
        act.Should().Throw<JsonReaderException>()
            .WithMessage("Unable to convert JSON value.");
    }

    #endregion

    #region WriteJson

    [Fact]
    public void WriteJson_WhenGivenANullValue_ShouldWriteNull()
    {
        // Act
        _sut.WriteJson(_jsonWriter, null, _serializer);

        // Assert
        A.CallTo(() => _jsonWriter.WriteNull()).MustHaveHappenedOnceExactly();
    }

    [Theory]
    [InlineData(false)]
    [InlineData("false")]
    [InlineData("False")]
    [InlineData("FALSE")]
    [InlineData("faLSE")]
    public void WriteJson_WhenGivenAFalseValue_ShouldWriteNull(object valueToWrite)
    {
        // Act
        _sut.WriteJson(_jsonWriter, valueToWrite, _serializer);

        // Assert
        A.CallTo(() => _jsonWriter.WriteNull()).MustHaveHappenedOnceExactly();
    }

    [Theory]
    [InlineData(true)]
    [InlineData("true")]
    [InlineData("True")]
    [InlineData("TRUE")]
    [InlineData("trUE")]
    public void WriteJson_WhenGivenATrueValue_ShouldWriteNull(object valueToWrite)
    {
        // Act
        _sut.WriteJson(_jsonWriter, valueToWrite, _serializer);

        // Assert
        A.CallTo(() => _jsonWriter.WriteValue(true)).MustHaveHappenedOnceExactly();
    }

    [Theory]
    [InlineData("[1, 2, 3]")]
    [InlineData("hello world")]
    public void WriteJson_WhenGivenAnUnsupportedValue_ShouldWriteNull(object valueToWrite)
    {
        // Act
        var act = () => _sut.WriteJson(_jsonWriter, valueToWrite, _serializer);

        // Assert
        act.Should().Throw<JsonWriterException>()
            .WithMessage("Unable to convert JSON value.");
    }

    #endregion

    #region Serialization/deserialization tests with a model

    public class TestModel
    {
        [JsonConverter(typeof(FalseToNullConverter))]
        public bool? Value { get; set; }
    }

    [Theory]
    [InlineData("\"\"")]
    [InlineData("null")]
    public void Deserialization_WhenGivenABooleanThatIsNullOrEmpty_ShouldOutputFalse(string valueToDeserialize)
    {
        // Setup
        var json = $$"""{ "Value": {{valueToDeserialize}} }""";

        // Act
        var model = JsonConvert.DeserializeObject<TestModel>(json);

        // Assert
        model.Should().NotBeNull();
        model.Value.Should().BeFalse();
    }

    [Theory]
    [InlineData("\"True\"", true)]
    [InlineData("true", true)]
    [InlineData("\"False\"", false)]
    [InlineData("false", false)]
    public void Deserialization_WhenGivenABooleanThatIsNotNull_ShouldOutputTheValue(string valueToDeserialize, bool expectedValue)
    {
        // Setup
        var json = $$"""{ "Value": {{valueToDeserialize}} }""";

        // Act
        var model = JsonConvert.DeserializeObject<TestModel>(json);

        // Assert
        model.Should().NotBeNull();
        model.Value
            .Should().NotBeNull()
            .And.Be(expectedValue, "the deserialized value should match the expected value");
    }

    [Theory]
    [InlineData(null)]
    [InlineData(false)]
    public void Serialization_WhenGivenABooleanThatIsNullOrFalse_ShouldOutputNull(bool? valueToSerialize)
    {
        // Setup
        const string expectedValue = """{"Value":null}""";
        var model = new TestModel { Value = valueToSerialize };

        // Act
        var json = JsonConvert.SerializeObject(model);

        // Assert
        json.Should().Be(expectedValue);
    }

    [Fact]
    public void Serialization_WhenGivenABooleanThatIsTrue_ShouldOutputTrue()
    {
        // Setup
        const string expectedValue = """{"Value":true}""";
        var model = new TestModel { Value = true };

        // Act
        var json = JsonConvert.SerializeObject(model);

        // Assert
        json.Should().Be(expectedValue);
    }

    #endregion
}
