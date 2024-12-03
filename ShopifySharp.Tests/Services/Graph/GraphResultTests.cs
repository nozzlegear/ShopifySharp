// ReSharper disable AccessToDisposedClosure
using System;
using System.Text.Json;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Graph;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "GraphResult"), TestSubject(typeof(GraphResult))]
public class GraphResultTests
{
    [Fact]
    public void GraphResult_WhenDisposed_ShouldDisposeJsonDocument()
    {
        // Setup
        var sut = new GraphResult
        {
            Json = JsonDocument.Parse("{ }")
        };
        var readJson = () => sut.Json.RootElement.GetArrayLength();

        // Act
        sut.Dispose();

        // Assert
        readJson.Should().Throw<ObjectDisposedException>();
    }
}
