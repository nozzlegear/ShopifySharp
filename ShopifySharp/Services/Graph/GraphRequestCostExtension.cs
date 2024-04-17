namespace ShopifySharp;

public class GraphRequestCostExtension
{
    public int RequestedQueryCost { get; set; }

    public int ActualQueryCost { get; set; }

    public required GraphRequestCostThrottleStatusExtension ThrottleStatus { get; set; }
}
