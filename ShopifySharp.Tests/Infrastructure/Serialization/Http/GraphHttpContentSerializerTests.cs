using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serialization.Http;

[Trait("Category", "Serialization"), TestSubject(typeof(GraphHttpContentSerializer))]
public class GraphHttpContentSerializerTests
{
    private const string Query = "some-query";
    private readonly RequestUri _requestUri = new (new Uri("https://example.com"));

    private readonly GraphHttpContentSerializer _sut = new(Serializer.GraphSerializerOptions);

    [Fact]
    public async Task SerializeGraphRequest_ShouldSerializeDataToJson()
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "baz", "bat" },
            { "hello", "world" },
        };

        // Act
        var result = _sut.SerializeGraphRequest(_requestUri, new GraphRequest
        {
            Query = Query,
            Variables = variables,
        });
        var jsonStr = await result.ReadAsStringAsync();

        // Assert
        jsonStr.Should().Be($$$"""{"query":"{{{Query}}}","variables":{"baz":"bat","hello":"world"}}""");
    }

#if NET6_0_OR_GREATER
    [Fact]
    public void SerializeGraphRequest_WhenExecutingInEnvironmentThatSupportsSystemMemory_ShouldReturnReadOnlyMemoryContent()
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "baz", "bat" },
            { "hello", "world" },
        };

        // Act
        var result = _sut.SerializeGraphRequest(_requestUri, new GraphRequest
        {
            Query = Query,
            Variables = variables,
        });

        // Assert
        result.Should().BeOfType<ReadOnlyMemoryContent>();
        result.Headers.ContentType?.MediaType.Should().Be("application/json");
    }
#else
    [Fact]
    public void SerializeGraphRequest_WhenExecutingInEnvironmentThatDoesNotSupportSystemMemory_ShouldReturnStringContent()
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "baz", "bat" },
            { "hello", "world" },
        };

        // Act
        var result = _sut.SerializeGraphRequest(_requestUri, new GraphRequest
        {
            Query = Query,
            Variables = variables,
        });

        // Assert
        result.Should().BeOfType<StringContent>();
        result.Headers.ContentType.MediaType.Should().Be("application/json");
    }
#endif

    #region Serializer.SerializerDefaults

    [Fact]
    public async Task WhenSerializingGraphRequest_ShouldOnlySerializeTheQueryAndVariablesPropertiesAndIgnoreAllOtherProperties()
    {
        // Setup
        var variables = new Dictionary<string, object>
        {
            { "baz", "bat" },
            { "hello", null },
            { "world", 1 }
        };
        const string expectedJson =
            $$$"""
              {"query":"{{{Query}}}","variables":{"baz":"bat","hello":null,"world":1}}
              """;

        // Act
        var result = _sut.SerializeGraphRequest(_requestUri, new GraphRequest
        {
            Query = Query,
            Variables = variables,
            EstimatedQueryCost = 123,
            UserErrorHandling = GraphRequestUserErrorHandling.DoNotThrow
        });
        var jsonStr = await result.ReadAsStringAsync();

        // Assert
        jsonStr.Should().Be(expectedJson);
    }

    #endregion
}
