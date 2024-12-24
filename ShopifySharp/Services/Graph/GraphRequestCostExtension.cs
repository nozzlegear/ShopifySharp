using System;

namespace ShopifySharp;

[Serializable]
public record GraphRequestCostExtension
{
    public int RequestedQueryCost { get; set; }

    public int ActualQueryCost { get; set; }

    #if NET60_OR_GREATER
    public required GraphRequestCostThrottleStatusExtension ThrottleStatus { get; set; }
    #else
    public GraphRequestCostThrottleStatusExtension ThrottleStatus { get; set; }
    #endif
}
