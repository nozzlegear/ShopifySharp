using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Services.Graph;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serializers;

[Trait("Category", "Serializer"), TestSubject(typeof(GraphHttpContentSerializer))]
public class GraphHttpContentSerializerTests
{
    private const string Query = "some-query";
    private readonly RequestUri _requestUri = new RequestUri(new Uri("https://example.com"));

    private readonly GraphHttpContentSerializer _sut = new(Serializer.SerializerDefaults);

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
    public void WhenSerializingGraphRequest_ShouldOnlySerializeTheQueryAndVariablesPropertiesAndIgnoreAllOtherProperties()
    {
        // Setup

        // Act

        // Assert
        Assert.Fail("not yet implemented");
    }

    [Fact]
    public void WhenSerializingGraphRequest_ShouldSerializeQueryAndVariablesPropertiesToCamelCase()
    {
        // Setup

        // Act

        // Assert
        Assert.Fail("not yet implemented");
    }

    [Fact]
    public void WhenSerializingGraphRequest_AndItIncludesEstimatedErrorCost_ShouldNotSerializeEstimatedErrorCostToJson()
    {
        // Setup

        // Act

        // Assert
        Assert.Fail("not yet implemented");
    }

    #endregion
}
