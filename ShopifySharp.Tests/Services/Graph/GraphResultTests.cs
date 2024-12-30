// ReSharper disable AccessToDisposedClosure
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.Services.Graph;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "GraphResult"), TestSubject(typeof(GraphResult))]
public class GraphResultTests
{
    [Fact]
    public void GraphResult_ShouldDisposeJsonNode()
    {
        // Setup
        var node = A.Fake<IJsonElement>();
        var sut = new GraphResult
        {
            Json = node
        };

        // Act
        sut.Dispose();

        // Assert
        A.CallTo(() => node.Dispose()).MustHaveHappened();
    }

    [Fact]
    public void GraphResult_WhenTheNodeIsAlreadyDisposed_ShouldNotThrow()
    {
        // Setup
        var node = A.Fake<IJsonElement>();
        var sut = new GraphResult
        {
            Json = node
        };

        // Act
        var act = () => sut.Dispose();

        // Assert
        act.Should().NotThrow();
        act.Should().NotThrow();

        A.CallTo(() => node.Dispose()).MustHaveHappenedOnceExactly();
    }
}
