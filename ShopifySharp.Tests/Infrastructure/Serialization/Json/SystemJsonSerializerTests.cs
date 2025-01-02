#nullable enable
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization"), TestSubject(typeof(SystemJsonSerializer))]
public class SystemJsonSerializerTests
{
    private readonly JsonSerializerOptions _jsonSerializerOptions = Serializer.GraphSerializerOptions;
    private readonly SystemJsonSerializer _sut;

    public SystemJsonSerializerTests()
    {
        _sut = new SystemJsonSerializer(_jsonSerializerOptions);
    }

    #region IJsonNode Parse(string value)

    [Fact]
    public void Parse_ShouldParseJsonIntoAJsonNode()
    {
        // Setup
        // lang=json
        const string json = """{"foo": "bar"}""";

        // Act
        var node = _sut.Parse(json);

        // Assert
        node.Should().NotBeNull();
        node.Should().BeOfType<SystemJsonElement>();
        node.GetProperty("foo").Should().NotBeNull();
    }

    [Fact]
    public void Parse_WhenGivenInvalidJson_ShouldThrow()
    {
        // Setup
        const string json = """{"foo": invalid json string}""";

        // Act
        var act = () => _sut.Parse(json);

        // Assert
        act.Should()
            .Throw<JsonException>()
            // We do not expect the exception to be assignable to a ShopifyException – it is not the serializer's responsibility to throw a ShopifyException
            .NotBeAssignableTo<ShopifyException>();
    }

    #endregion

    #region string Serialize<T>(T item)

    [Fact]
    public void Serialize_T_ShouldSerializeTheObjectToJson()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        const string expectedBarValue = "some-expected-bar-value";
        const string expectedJson = $$"""{"foo":"{{expectedFooValue}}","bar":"{{expectedBarValue}}"}""";
        var item = new SystemJsonTestObject { Foo = expectedFooValue, Bar = expectedBarValue };

        // Act
        var json = _sut.Serialize(item);

        // Assert
        json.Should().Be(expectedJson);
    }

    [Fact]
    public void Serialize_T_WhenBarIsNull_ShouldSerializeTheObjectToJsonAndExcludeTheBarProperty()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        const string expectedJson = $$"""{"foo":"{{expectedFooValue}}"}""";
        var item = new SystemJsonTestObject { Foo = expectedFooValue, Bar = null };

        // Act
        var json = _sut.Serialize(item);

        // Assert
        json.Should().Be(expectedJson);
    }

    #endregion

    #region ValueTask SerializeAsync<T>(Stream target, T item)

    [Fact]
    public async Task SerializeAsync_T_ShouldSerializeTheObjectToJsonAndWriteItToTheStream()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        const string expectedJson = $$"""{"foo":"{{expectedFooValue}}"}""";
        var item = new SystemJsonTestObject { Foo = expectedFooValue, Bar = null };
        #if NET8_0_OR_GREATER
        await using var stream = new MemoryStream();
        #else
        using var stream = new MemoryStream();
        #endif

        // Act
        await _sut.SerializeAsync(stream, item);

        // Assert
        stream.Should().HavePosition(0, "the method should have reset the stream position to 0");

        using var streamReader = new StreamReader(stream);
        var json = await streamReader.ReadToEndAsync();

        json.Should().Be(expectedJson);
    }

    [Fact]
    public async Task SerializeAsync_T_WhenBarIsNull_ShouldSerializeTheObjectToJsonExcludingTheBarPropertyAndWriteTheJsonToTheStream()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        const string expectedBarValue = "some-expected-bar-value";
        const string expectedJson = $$"""{"foo":"{{expectedFooValue}}","bar":"{{expectedBarValue}}"}""";
        var item = new SystemJsonTestObject { Foo = expectedFooValue, Bar = expectedBarValue };
        #if NET8_0_OR_GREATER
        await using var stream = new MemoryStream();
        #else
        using var stream = new MemoryStream();
        #endif

        // Act
        await _sut.SerializeAsync(stream, item);

        // Assert
        stream.Should().HavePosition(0, "the method should have reset the stream position to 0");

        using var streamReader = new StreamReader(stream);
        var json = await streamReader.ReadToEndAsync();

        json.Should().Be(expectedJson);
    }

    #endregion

    #region object? Deserialize(IJsonNode jsonNode, Type type)

    [Fact]
    public void Deserialize_ShouldDeserializeTheNodeToTheRequestedType()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var deserializedObject = _sut.Deserialize(element, typeof(SystemJsonTestObject));

        // Assert
        deserializedObject.Should()
            .NotBeNull()
            .And
            .BeOfType<SystemJsonTestObject>()
            .Which
            .Should()
            .BeEquivalentTo(new SystemJsonTestObject() { Foo = expectedFooValue });
    }

    [Theory]
    [InlineData(typeof(int), true)]
    [InlineData(typeof(bool), true)]
    [InlineData(typeof(string), true)]
    [InlineData(typeof(string[]), true)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(Product), false)]
    public void Deserialize_WhenThePrimitiveTypesDoNotMatch_ShouldThrow(Type type, bool shouldThrow)
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var act = () => _sut.Deserialize(element, type);

        // Assert
        if (shouldThrow)
        {
            act.Should()
                .Throw<JsonException>()
                // We do not expect the exception to be assignable to a ShopifyException – it is not the serializer's responsibility to throw a ShopifyException
                .NotBeAssignableTo<ShopifyException>();
        }
        else
        {
            act.Should()
                .NotThrow()
                .Which
                .Should()
                // Although it does not throw, the serializer is not expected to return null here – rather it returns an empty object
                .NotBeNull();
        }
    }

    [Fact]
    public void Deserialize_WhenTheNodeIsNotASystemTextJsonNode_ShouldThrow()
    {
        // Setup
        var fakeNode = A.Fake<IJsonElement>();

        // Act
        var act = () => _sut.Deserialize(fakeNode, typeof(SystemJsonTestObject));

        // Assert
        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"Expected a {nameof(SystemJsonElement)} but got *. (Parameter 'element')")
            .And
            .ParamName
            .Should()
            .Be("element");
    }

    #endregion

    #region T? Deserialize<T>(IJsonNode jsonNode)

    [Fact]
    public void Deserialize_T_ShouldDeserializeTheNodeToTheRequestedType()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var deserializedObject = _sut.Deserialize<SystemJsonTestObject>(element);

        // Assert
        deserializedObject.Should()
            .NotBeNull()
            .And
            .BeOfType<SystemJsonTestObject>()
            .Which
            .Should()
            .BeEquivalentTo(new SystemJsonTestObject() { Foo = expectedFooValue });
    }

    [Theory]
    [InlineData(GenericTargetType.Int, true)]
    [InlineData(GenericTargetType.Bool, true)]
    [InlineData(GenericTargetType.String, true)]
    [InlineData(GenericTargetType.StringArray, true)]
    [InlineData(GenericTargetType.Object, false)]
    [InlineData(GenericTargetType.Product, false)]
    public void Deserialize_T_WhenThePrimitiveTypesDoNotMatch_ShouldThrow(GenericTargetType type, bool shouldThrow)
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        Func<object?> act = type switch
        {
            GenericTargetType.Int => () => _sut.Deserialize<int>(element),
            GenericTargetType.Bool => () => _sut.Deserialize<bool>(element),
            GenericTargetType.String => () => _sut.Deserialize<string>(element),
            GenericTargetType.StringArray => () => _sut.Deserialize<string[]>(element),
            GenericTargetType.Object => () => _sut.Deserialize<object>(element),
            GenericTargetType.Product => () => _sut.Deserialize<Product>(element),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

        // Assert
        if (shouldThrow)
        {
            act.Should()
                .Throw<JsonException>()
                // We do not expect the exception to be assignable to a ShopifyException – it is not the serializer's responsibility to throw a ShopifyException
                .NotBeAssignableTo<ShopifyException>();
        }
        else
        {
            act.Should()
                .NotThrow()
                .Which
                .Should()
                // Although it does not throw, the serializer is not expected to return null here – rather it returns an empty object
                .NotBeNull();
        }
    }

    [Fact]
    public void Deserialize_T_WhenTheNodeIsNotASystemTextJsonNode_ShouldThrow()
    {
        // Setup
        var fakeNode = A.Fake<IJsonElement>();

        // Act
        var act = () => _sut.Deserialize<SystemJsonTestObject>(fakeNode);

        // Assert
        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"Expected a {nameof(SystemJsonElement)} but got *. (Parameter 'element')")
            .And
            .ParamName
            .Should()
            .Be("element");
    }

    #endregion

    #region ValueTask<object?> DeserializeAsync(IJsonNode jsonNode, Type type)

    [Fact]
    public async Task DeserializeAsync_ShouldDeserializeTheNodeToTheRequestedType()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var deserializedObject = await _sut.DeserializeAsync(element, typeof(SystemJsonTestObject));

        // Assert
        deserializedObject.Should()
            .NotBeNull()
            .And
            .BeOfType<SystemJsonTestObject>()
            .Which
            .Should()
            .BeEquivalentTo(new SystemJsonTestObject() { Foo = expectedFooValue });
    }

    [Theory]
    [InlineData(typeof(int), true)]
    [InlineData(typeof(bool), true)]
    [InlineData(typeof(string), true)]
    [InlineData(typeof(string[]), true)]
    [InlineData(typeof(object), false)]
    [InlineData(typeof(Product), false)]
    public async Task DeserializeAsync_WhenThePrimitiveTypesDoNotMatch_ShouldThrow(Type type, bool shouldThrow)
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var act = async () => await _sut.DeserializeAsync(element, type);

        // Assert
        if (shouldThrow)
        {
            var exn = await act.Should().ThrowAsync<JsonException>();
                // We do not expect the exception to be assignable to a ShopifyException – it is not the serializer's responsibility to throw a ShopifyException
            exn.NotBeAssignableTo<ShopifyException>();
        }
        else
        {
            var result = await act.Should().NotThrowAsync();
            // Although it does not throw, the serializer is not expected to return null here – rather it returns an empty object
            result.Subject.Should().NotBeNull();
        }
    }

    [Fact]
    public async Task DeserializeAsync_WhenTheNodeIsNotASystemTextJsonNode_ShouldThrow()
    {
        // Setup
        var fakeNode = A.Fake<IJsonElement>();

        // Act
        var act = async () => await _sut.DeserializeAsync(fakeNode, typeof(SystemJsonTestObject));

        // Assert
        var exn = await act.Should()
            .ThrowAsync<ArgumentException>()
            .WithMessage($"Expected a {nameof(SystemJsonElement)} but got *. (Parameter 'element')");
        exn.And.ParamName.Should().Be("element");
    }

    #endregion

    #region ValueTask<T?> DeserializeAsync<T>(IJsonNode jsonNode)

    [Fact]
    public async Task DeserializeAsync_T_ShouldDeserializeTheNodeToTheRequestedType()
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        var deserializedObject = await _sut.DeserializeAsync<SystemJsonTestObject>(element);

        // Assert
        deserializedObject.Should()
            .NotBeNull()
            .And
            .BeOfType<SystemJsonTestObject>()
            .Which
            .Should()
            .BeEquivalentTo(new SystemJsonTestObject() { Foo = expectedFooValue });
    }

    [Theory]
    [InlineData(GenericTargetType.Int, true)]
    [InlineData(GenericTargetType.Bool, true)]
    [InlineData(GenericTargetType.String, true)]
    [InlineData(GenericTargetType.StringArray, true)]
    [InlineData(GenericTargetType.Object, false)]
    [InlineData(GenericTargetType.Product, false)]
    public async Task DeserializeAsync_T_WhenTheTypeDoesNotMatch_ShouldThrow(GenericTargetType type, bool shouldThrow)
    {
        // Setup
        const string expectedFooValue = "some-expected-foo-value";
        IJsonElement element = new SystemJsonElement(JsonDocument.Parse($$"""{"foo": "{{expectedFooValue}}"}"""));

        // Act
        Func<Task<object?>> act = type switch
        {
            GenericTargetType.Int => async () => await _sut.DeserializeAsync<int>(element),
            GenericTargetType.Bool => async () => await _sut.DeserializeAsync<bool>(element),
            GenericTargetType.String => async () => await _sut.DeserializeAsync<string>(element),
            GenericTargetType.StringArray => async () => await _sut.DeserializeAsync<string[]>(element),
            GenericTargetType.Object => async () => await _sut.DeserializeAsync<object>(element),
            GenericTargetType.Product => async () => await _sut.DeserializeAsync<Product>(element),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

        // Assert
        if (shouldThrow)
        {
            var exn = await act.Should().ThrowAsync<JsonException>();
                // We do not expect the exception to be assignable to a ShopifyException – it is not the serializer's responsibility to throw a ShopifyException
            exn.NotBeAssignableTo<ShopifyException>();
        }
        else
        {
            var result = await act.Should().NotThrowAsync();
            // Although it does not throw, the serializer is not expected to return null here – rather it returns an empty object
            result.Subject.Should().NotBeNull();
        }
    }

    [Fact]
    public async Task DeserializeAsync_T_WhenTheNodeIsNotASystemTextJsonNode_ShouldThrow()
    {
        // Setup
        var fakeNode = A.Fake<IJsonElement>();

        // Act
        var act = async () => await _sut.DeserializeAsync<SystemJsonTestObject>(fakeNode);

        // Assert
        var exn = await act.Should()
            .ThrowAsync<ArgumentException>()
            .WithMessage($"Expected a {nameof(SystemJsonElement)} but got *. (Parameter 'element')");
        exn.And.ParamName.Should().Be("element");
    }

    #endregion

    private class SystemJsonTestObject
    {
        public string Foo { get; set; } = null!;
        public string? Bar { get; set; }
    }

    public enum GenericTargetType
    {
        Int,
        Bool,
        String,
        StringArray,
        Object,
        Product,
    }
}
