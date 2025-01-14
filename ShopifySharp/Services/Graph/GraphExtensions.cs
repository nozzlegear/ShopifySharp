#nullable enable

using System;

namespace ShopifySharp.Services.Graph;

[Serializable]
public record GraphExtensions
{
    #if NET8_0_OR_GREATER
    public required GraphRequestCostExtension Cost { get; set; }
    #else
    public GraphRequestCostExtension Cost { get; set; } = default!;
    #endif
}
