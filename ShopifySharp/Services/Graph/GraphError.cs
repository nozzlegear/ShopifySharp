#nullable enable
using System.Collections.Generic;

namespace ShopifySharp.Services.Graph;

public record GraphError
{
    // TODO: make this nullable
    public string Message { get; set; } = string.Empty;

    public IReadOnlyList<string>? Path { get; set; }

    public GraphErrorExtensions? Extensions { get; set; }
}
