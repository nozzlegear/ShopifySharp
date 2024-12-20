namespace ShopifySharp;

public class GraphRequestCostThrottleStatusExtension
{
    public int RestoreRate { get; set; }

    public int CurrentlyAvailable { get; set; }

    public int MaximumAvailable { get; set; }
}
