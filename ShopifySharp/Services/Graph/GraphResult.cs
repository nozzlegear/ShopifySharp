#nullable enable

using System;
using System.Text.Json;
using ShopifySharp.Infrastructure.Serialization.Json;

namespace ShopifySharp.Graph;

public class GraphResult<T>
{
    public GraphExtensions? Extensions { get; set; }

    #if NET8_0_OR_GREATER
    public required T Data { get; set; }
    #else
    public T Data { get; set; } = default!;
    #endif

    public string? RequestId { get; set; }
}

public class GraphResult : IDisposable
{
    private bool Disposed { get; set; }

    #if NET8_0_OR_GREATER
    public required IJsonElement Json { get; set; }
    #else
    public IJsonElement Json { get; set; } = null!;
    #endif

    public string? RequestId { get; set; }

    public void Dispose()
    {
        if (Disposed) return;
        Disposed = true;
        Json.Dispose();
    }
}
