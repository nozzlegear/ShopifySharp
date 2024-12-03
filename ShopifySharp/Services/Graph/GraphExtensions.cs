#nullable enable

using System;

namespace ShopifySharp.Graph;

[Serializable]
public class GraphExtensions
{
    #if NET60_OR_GREATER
    public required GraphRequestCostExtension Cost { get; set; }
    #else
    public GraphRequestCostExtension Cost { get; set; } = default!;
    #endif
}
