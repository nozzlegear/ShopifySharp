using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serialization;

[Trait("Category", "Serialization"), TestSubject(typeof(Serializer))]
public class SerializerTests
{
    #region (Newtonsoft) Serializer.Serialize

    [Theory]
    [InlineData("º")]
    [InlineData("<")]
    [InlineData(">")]
    public void Serialize_WhenSerializingHtmlEncodableCharacters_ShouldNotEncodeToHtml(string encodableCharacter)
    {
        // Act
        var json = Serializer.Serialize(encodableCharacter);

        // Assert
        json.Should().Be($"\"{encodableCharacter}\"");
    }

    [Theory]
    [InlineData("Spiral flute 40º")]
    [InlineData("Spiral flute 40<")]
    [InlineData("Spiral flute 40>")]
    public void Serialize_WhenSerializingProductObjectWithHtmlEncodableCharacters_ShouldNotEncodeToHtml(string productTitle)
    {
        // Setup
        var expectedJson = $$"""{"title":"{{productTitle}}","published_at":null}""";
        var product = new Product { Title = productTitle };

        // Act
        var json = Serializer.Serialize(product);

        // Assert
        json.Should().Be(expectedJson);
    }

    #endregion

    #region (Newtonsoft) Serializer.Deserialize(string json, Type objectType)

    [Theory]
    [InlineData("º")]
    [InlineData("<")]
    [InlineData(">")]
    public void Deserialize_WhenDeserializingHtmlEncodableStrings_ShouldNotDeserializeToEncodableHtml(string encodableCharacter)
    {
        // Setup
        var json = $$"""{"foo":"{{encodableCharacter}}"}""";

        // Act
        var result = Serializer.Deserialize(json, typeof(TestFoo));

        // Assert
        result.Should().BeOfType(typeof(TestFoo));
        result.As<TestFoo>().Foo.Should().Be(encodableCharacter);
    }

    [Theory]
    [InlineData("Spiral flute 40º")]
    [InlineData("Spiral flute 40<")]
    [InlineData("Spiral flute 40>")]
    public void Deserialize_WhenDeserializingProductObjectWithHtmlEncodableCharacters_ShouldNotDeserializeToEncodableHtml(string productTitle)
    {
        // Setup
        var json = $$"""{"title":"{{productTitle}}","published_at":null}""";
        var expectedProduct = new Product { Title = productTitle, PublishedAt = null };

        // Act
        var result = Serializer.Deserialize(json, typeof(Product));

        // Assert
        result.Should().BeOfType(typeof(Product));
        result.As<Product>().Should().BeEquivalentTo(expectedProduct);
    }

    #endregion

    #region (Newtonsoft) Serializer.Deserialize<T>(string json, string rootElementPath = null, DateParseHandling? dateParseHandlingOverride = null)}

    [Theory]
    [InlineData("º")]
    [InlineData("<")]
    [InlineData(">")]
    public void Deserialize_T_WhenDeserializingHtmlEncodableStrings_ShouldNotDeserializeToEncodableHtml(string encodableCharacter)
    {
        // Setup
        var json = $$"""{"foo":"{{encodableCharacter}}"}""";

        // Act
        var result = Serializer.Deserialize<TestFoo>(json);

        // Assert
        result.Foo.Should().Be(encodableCharacter);
    }

    [Theory]
    [InlineData("Spiral flute 40º")]
    [InlineData("Spiral flute 40<")]
    [InlineData("Spiral flute 40>")]
    public void Deserialize_T_WhenDeserializingProductObjectWithHtmlEncodableStrings_ShouldNotDeserializeToEncodableHtml(string productTitle)
    {
        // Setup
        var json = $$"""{"title":"{{productTitle}}","published_at":null}""";
        var expectedProduct = new Product { Title = productTitle, PublishedAt = null };

        // Act
        var result = Serializer.Deserialize<Product>(json);

        // Assert
        result.Should().BeEquivalentTo(expectedProduct);
    }

    [Theory]
    [InlineData("Spiral flute 40º")]
    [InlineData("Spiral flute 40<")]
    [InlineData("Spiral flute 40>")]
    public void Deserialize_T_WhenDeserializingProductObjectWithHtmlEncodableStrings_AndUsingRootPath_ShouldNotDeserializeToEncodableHtml(string productTitle)
    {
        // Setup
        var json = $$"""{"title":"{{productTitle}}","published_at":null}""";

        // Act
        var result = Serializer.Deserialize<string>(json, "title");

        // Assert
        result.Should().BeEquivalentTo(productTitle);
    }

    #endregion

    private record TestFoo
    {
        public string Foo { get; set; }
    }
}
