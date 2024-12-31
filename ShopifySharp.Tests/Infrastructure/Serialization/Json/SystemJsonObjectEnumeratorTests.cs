using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure.Serialization.Json;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Json;

[Trait("Category", "Serialization"), TestSubject(typeof(SystemJsonObjectEnumerator))]
public class SystemJsonObjectEnumeratorTests
{
    [Fact]
    public void GetEnumerator_ShouldEnumerateObjectValues()
    {
        // Setup
        using var doc = JsonDocument.Parse("""{"foo":123,"bar":"abc"}""");
        var objectEnumerator = doc.RootElement.EnumerateObject();
        var sut = new SystemJsonObjectEnumerator(objectEnumerator);

        // Act
        var results = sut.ToList();

        // Assert
        results.Should().HaveCount(2);
        results[0].GetRawObject().Should().BeOfType<JsonElement>().Which.GetInt32().Should().Be(123);
        results[1].GetRawObject().Should().BeOfType<JsonElement>().Which.GetString().Should().Be("abc");
    }

    [Fact]
    public void GetEnumerator_WhenCastToAnIEnumerable_ShouldGetEnumeratorAndIterate()
    {
        // Setup
        using var doc = JsonDocument.Parse("""{"foo":123,"bar":"abc"}""");
        var objectEnumerator = doc.RootElement.EnumerateObject();
        IEnumerable sut = new SystemJsonObjectEnumerator(objectEnumerator);
        var props = new List<JsonValueType>();

        // Act
        foreach (var item in sut)
        {
            if (item is SystemJsonElement {ValueType: var valueType})
                props.Add(valueType);
        }

        // Assert
        props.Should().HaveCount(2);
        props.Should().ContainInOrder(JsonValueType.Number, JsonValueType.String);
    }

    [Fact]
    public void Dispose_CalledMultipleTimes_DoesNotThrow()
    {
        // Setup
        using var doc = JsonDocument.Parse("""{"foo":"bar"}""");
        var objectEnumerator = doc.RootElement.EnumerateObject();
        var sut = new SystemJsonObjectEnumerator(objectEnumerator);

        // Act
        var act = () =>
        {
            for (var i = 0; i < 4; i++)
                sut.Dispose();
        };

        // Assert
        act.Should().NotThrow();
    }
}
