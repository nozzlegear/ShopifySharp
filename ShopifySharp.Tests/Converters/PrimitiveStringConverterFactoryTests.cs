using System;
using System.Collections.Generic;
using System.Text.Json;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Converters.SystemTextJson;
using Xunit;

namespace ShopifySharp.Tests.Converters;

[Trait("Category", "Converters")]
[Trait("Category", "SystemTextJson")]
[TestSubject(typeof(PrimitiveStringConverterFactory))]
public class PrimitiveStringConverterFactoryTests
{
    private readonly PrimitiveStringConverterFactory _factory;
    private readonly JsonSerializerOptions _options;

    public PrimitiveStringConverterFactoryTests()
    {
        _factory = new PrimitiveStringConverterFactory();
        _options = new JsonSerializerOptions();
        _options.Converters.Add(new PrimitiveStringConverter());
    }

    #region CanConvert Tests

    [Theory]
    [InlineData(typeof(string), true)]
    [InlineData(typeof(IEnumerable<string>), true)]
    [InlineData(typeof(IReadOnlyList<string>), true)]
    [InlineData(typeof(ICollection<string>), true)]
    [InlineData(typeof(List<string>), true)]
    [InlineData(typeof(int), false)]
    [InlineData(typeof(bool), false)]
    public void CanConvert_WhenTypeIsSupported_ShouldReturnTrue(Type typeToConvert, bool shouldPass)
    {
        // Act
        var result = _factory.CanConvert(typeToConvert);

        // Assert
        if (shouldPass)
            result.Should().BeTrue("the type {0} is supported by the factory", typeToConvert);
        else
            result.Should().BeFalse("the type {0} is not supported by the factory", typeToConvert);
    }

    #endregion

    #region CreateConverter Tests

    [Fact]
    public void CreateConverter_WhenTypeIsString_ShouldReturnPrimitiveStringConverter()
    {
        // Setup
        var typeToConvert = typeof(string);

        // Act
        var converter = _factory.CreateConverter(typeToConvert, _options);

        // Assert
        converter.Should().NotBeNull().And.BeOfType<PrimitiveStringConverter>();
    }

    [Theory]
    [InlineData(typeof(IEnumerable<string>))]
    [InlineData(typeof(IReadOnlyList<string>))]
    [InlineData(typeof(ICollection<string>))]
    [InlineData(typeof(List<string>))]
    public void CreateConverter_WhenTypeIsIEnumerableOfString_ShouldReturnPrimitiveStringListConverter(Type typeToConvert)
    {
        // Act
        var converter = _factory.CreateConverter(typeToConvert, _options);

        // Assert
        converter.Should().NotBeNull()
            .And
            .BeOfType(typeof(PrimitiveStringListConverter<>).MakeGenericType(typeToConvert), "the converter's type should be PrimitiveStringListConverter<{0}>", typeToConvert.Name);
    }

    [Fact]
    public void CreateConverter_WhenTypeIsNotSupported_ShouldReturnNull()
    {
        // Setup
        var typeToConvert = typeof(int);

        // Act
        var converter = _factory.CreateConverter(typeToConvert, _options);

        // Assert
        converter.Should().BeNull();
    }

    #endregion
}
