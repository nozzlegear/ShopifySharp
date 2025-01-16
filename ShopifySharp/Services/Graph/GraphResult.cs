#nullable enable

using System;
using ShopifySharp.Infrastructure.Serialization.Json;

namespace ShopifySharp.Services.Graph;

public class GraphResult<T>
{
    public GraphExtensions? Extensions { get; set; }

    #if NET8_0_OR_GREATER
    public required T Data { get; set; }
    #else
    public T Data { get; set; } = default!;
    #endif

    /// The X-Request-Id header returned by Shopify. This can be used when working with the Shopify support team to identify the failed request.
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

    /// The X-Request-Id header returned by Shopify. This can be used when working with the Shopify support team to identify the failed request.
    public string? RequestId { get; set; }

    public void Dispose()
    {
        if (Disposed) return;
        Disposed = true;
        Json.Dispose();
    }
}
