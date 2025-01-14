using System;

namespace ShopifySharp.Services.Graph;

[Serializable]
public record GraphRequestCostExtension
{
    public int RequestedQueryCost { get; set; }

    public int ActualQueryCost { get; set; }

    #if NET8_0_OR_GREATER
    public required GraphRequestCostThrottleStatusExtension ThrottleStatus { get; set; }
    #else
    public GraphRequestCostThrottleStatusExtension ThrottleStatus { get; set; }
    #endif
}
