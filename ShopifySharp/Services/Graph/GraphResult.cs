#nullable enable

using System;
using System.Text.Json;

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
    #if NET8_0_OR_GREATER
    public required JsonDocument Json { get; set; }
    #else
    public JsonDocument Json { get; set; } = default!;
    #endif

    public string? RequestId { get; set; }

    public void Dispose()
    {
        Json.Dispose();
    }
}
