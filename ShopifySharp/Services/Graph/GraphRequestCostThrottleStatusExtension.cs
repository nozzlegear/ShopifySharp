namespace ShopifySharp;

public class GraphRequestCostThrottleStatusExtension
{
    public double RestoreRate { get; set; }

    public double CurrentlyAvailable { get; set; }

    public double MaximumAvailable { get; set; }
}
