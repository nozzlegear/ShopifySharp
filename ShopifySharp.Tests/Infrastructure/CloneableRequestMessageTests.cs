#nullable enable
using System;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using Xunit;
#pragma warning disable CS0618 // Type or member is obsolete

namespace ShopifySharp.Tests.Infrastructure;

[Trait("Category", "DotNetFramework")]
[Trait("Category", nameof(CloneableRequestMessage))]
[TestSubject(typeof(CloneableRequestMessage))]
public class CloneableRequestMessageTests
{
    private static readonly Uri Host = new("https://fake-url.com/admin/api.json");
    private static readonly HttpMethod Method = HttpMethod.Post;

    [Fact]
    public void Clone_ShouldCloneWithNoHttpContent_AndPreserveHeaders()
    {
        // Setup
        var cloneableRequest = new CloneableRequestMessage(Host, Method);
        cloneableRequest.Headers.Add("some-key", "some-value");

        // Act
        var clonedRequest = cloneableRequest.Clone();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().BeNull();
        clonedRequest.Headers.Should().ContainKey("some-key")
            .WhoseValue.Should().Contain("some-value");
    }

    [Fact]
    public void Clone_ShouldCloneJsonContent_AndPreserveHeaders()
    {
        // Setup
        var jsonContent = new JsonContent(new { Foo = "bar" })
        {
            Headers = { {"some-key-1", "some-value-1"} }
        };
        var cloneableRequest = new CloneableRequestMessage(Host, Method, jsonContent);
        cloneableRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = cloneableRequest.Clone();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["application/json"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }

    [Fact]
    public void Clone_ShouldNotThrowWhenCloningDisposedRequest()
    {
        // The original Clone method did not interact with the underlying request's memory stream. Instead,
        // it holds the original data object in memory and reserializes it to a byte array on each clone.
        // It is only serializing the request/content into an Http pipeline that will throw an exception here.

        // Setup
        var jsonContent = new JsonContent(new { Foo = "bar" })
        {
            Headers = { {"some-key-1", "some-value-1"} }
        };
        var cloneableRequest = new CloneableRequestMessage(Host, Method, jsonContent);
        cloneableRequest.Dispose();

        // Act
        var clonedRequest = () => cloneableRequest.Clone();

        // Assert
        clonedRequest.Should().NotThrow();
    }

    [Fact]
    public void Clone_ShouldCloneMultipleTimesWithoutDisposalExceptions()
    {
        // Setup
        var jsonContent = new JsonContent(new { Foo = "bar" })
        {
            Headers = { {"some-key-1", "some-value-1"} }
        };
        var baseRequest = new TestCloneableRequestMessage(Host, Method, jsonContent);

        // Act
        var act = () =>
        {
            for (var i = 0; i < 5; i++)
            {
                var clonedRequest = baseRequest.Clone();

                clonedRequest.Should().NotBeNull();
                clonedRequest.RequestUri.Should().Be(Host);
                clonedRequest.Method.Should().Be(Method);
                clonedRequest.Content.Should().NotBeNull();
                clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
                    .WhoseValue.Should().BeEquivalentTo(["application/json"]);
            }
        };

        // Assert
        act.Should().NotThrow();
        baseRequest.Disposed.Should().BeFalse();
    }

    #region CloneAsync

    [Fact]
    public async Task CloneAsync_ShouldThrowWhenCloningDisposedRequest()
    {
        // Setup
        var jsonContent = new JsonContent(new { Foo = "bar" })
        {
            Headers = { {"some-key-1", "some-value-1"} }
        };
        var cloneableRequest = new CloneableRequestMessage(Host, Method, jsonContent);
        cloneableRequest.Dispose();

        // Act
        var clonedRequest = async () => await cloneableRequest.CloneAsync();

        // Assert
        await clonedRequest.Should().ThrowAsync<ObjectDisposedException>();
    }

    [Fact]
    public async Task CloneAsync_ShouldCloneWithNoHttpContent_AndPreserveHeaders()
    {
        // Setup
        var cloneableRequest = new CloneableRequestMessage(Host, Method);
        cloneableRequest.Headers.Add("some-key", "some-value");

        // Act
        var clonedRequest = await cloneableRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().BeNull();
        clonedRequest.Headers.Should().ContainKey("some-key")
            .WhoseValue.Should().BeEquivalentTo(["some-value"]);
    }

    [Fact]
    public async Task CloneAsync_ShouldCloneJsonContent_AndPreserveHeaders()
    {
        // Setup
        var jsonContent = new JsonContent(new { Foo = "bar" })
        {
            Headers = { {"some-key-1", "some-value-1"} }
        };
        var cloneableRequest = new CloneableRequestMessage(Host, Method, jsonContent);
        cloneableRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = await cloneableRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["application/json"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }

    [Fact]
    public async Task CloneAsync_ShouldCloneStringContent_AndPreserveHeaders()
    {
        // Setup
        var stringContent = new StringContent("some-string-content")
        {
            Headers = 
            { 
                {"some-key-1", "some-value-1"}
            }
        };
        // The StringContent class has weird class-specific logic around the Content-Type header that set it explicitly
        stringContent.Headers.Remove("Content-Type");
        stringContent.Headers.Add("Content-Type", "fake/string");
        var cloneableRequest = new CloneableRequestMessage(Host, Method, stringContent);
        cloneableRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = await cloneableRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["fake/string"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }

    [Fact]
    public async Task CloneAsync_ShouldCloneByteArrayContent_AndPreserveHeaders()
    {
        // Setup
        var str = "some-string-content";
        var bytes = Encoding.UTF8.GetBytes(str);
        var byteContent = new ByteArrayContent(bytes)
        {
            Headers = 
            { 
                {"some-key-1", "some-value-1"}, 
                { "Content-Type", "fake/bytes" } 
            }
        };
        var cloneableRequest = new CloneableRequestMessage(Host, Method, byteContent);
        cloneableRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = await cloneableRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["fake/bytes"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }

    [Fact]
    public async Task CloneAsync_ShouldCloneStreamContent_AndPreserveHeaders()
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes("some-stream-content");
        var ms = new MemoryStream(bytes);
        var streamContent = new StreamContent(ms)
        {
            Headers = 
            {
                {"some-key-1", "some-value-1"}, 
                { "Content-Type", "fake/stream" }
            }
        };
        var baseRequest = new CloneableRequestMessage(Host, Method, streamContent);
        baseRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = await baseRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["fake/stream"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }

    #if NET6_0_OR_GREATER
    [Fact]
    public async Task CloneAsync_ShouldCloneReadOnlyMemoryContent_AndPreserveHeaders()
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes("some-stream-content");
        var readOnlyMemory = new ReadOnlyMemory<byte>(bytes);
        var memoryContent = new ReadOnlyMemoryContent(readOnlyMemory)
        {
            Headers = 
            {
                {"some-key-1", "some-value-1"}, 
                { "Content-Type", "fake/memory" }
            }
        };
        var baseRequest = new CloneableRequestMessage(Host, Method, memoryContent);
        baseRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var clonedRequest = await baseRequest.CloneAsync();

        // Assert
        clonedRequest.Should().NotBeNull();
        clonedRequest.RequestUri.Should().Be(Host);
        clonedRequest.Method.Should().Be(Method);
        clonedRequest.Content.Should().NotBeNull();
        clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
            .WhoseValue.Should().BeEquivalentTo(["fake/memory"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
            .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
        clonedRequest.Headers.Should().ContainKey("some-key-2")
            .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
    }
    #endif

    [Fact]
    public async Task CloneAsync_ShouldCloneMultipleTimesWithoutDisposalExceptions()
    {
        // Setup
        var bytes = Encoding.UTF8.GetBytes("some-stream-content");
        var ms = new MemoryStream(bytes);
        var streamContent = new StreamContent(ms)
        {
            Headers = 
            {
                {"some-key-1", "some-value-1"}, 
                { "Content-Type", "fake/stream" }
            }
        };
        var baseRequest = new TestCloneableRequestMessage(Host, Method, streamContent);
        baseRequest.Headers.Add("some-key-2", "some-value-2");

        // Act
        var act = async () =>
        {
            for (var i = 0; i < 5; i++)
            {
                var clonedRequest = await baseRequest.CloneAsync();

                // Assert
                clonedRequest.Should().NotBeNull();
                clonedRequest.RequestUri.Should().Be(Host);
                clonedRequest.Method.Should().Be(Method);
                clonedRequest.Content.Should().NotBeNull();
                clonedRequest.Content!.Headers.Should().ContainKey("Content-Type")
                    .WhoseValue.Should().BeEquivalentTo(["fake/stream"]);
                clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
                    .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
                clonedRequest.Content!.Headers.Should().ContainKey("some-key-1")
                    .WhoseValue.Should().BeEquivalentTo(["some-value-1"]);
                clonedRequest.Headers.Should().ContainKey("some-key-2")
                    .WhoseValue.Should().BeEquivalentTo(["some-value-2"]);
            }
        };

        await act.Should().NotThrowAsync();
        baseRequest.Disposed.Should().BeFalse();
    }

    #endregion

    [Fact]
    public async Task Dispose_ShouldDisposeAfterBeingCloned()
    {
        // Essentially this should test that there's never a whole bunch of cloneable requests awaiting disposal,
        // it should only be the previous request and the current request.

        // Setup
        var stringContent = new StringContent("some-string-content");
        var baseRequest = new TestCloneableRequestMessage(Host, Method, stringContent);

        // Act
        var act = async () => 
        {
            for (var i = 0; i < 3; i++)
            {
                var clonedRequest = await baseRequest.CloneAsync();
                clonedRequest.Dispose();
            }
        };

        await act.Should().NotThrowAsync();
        baseRequest.Disposed.Should().BeFalse();
    }

    private class TestCloneableRequestMessage(Uri url, HttpMethod method, HttpContent? content = null)
        : CloneableRequestMessage(url, method, content)
    {
        public bool Disposed { get; private set; }

        protected override void Dispose(bool disposing)
        {
            Disposed = true;
            base.Dispose(disposing);
        }
    }
}
