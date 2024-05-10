namespace ShopifySharp;

public class GraphQLBucketState
{
    public int MaxAvailable { get; private set; }

    public int RestoreRate { get; private set; }

    public int CurrentlyAvailable { get; private set; }

    public int RequestedQueryCost { get; private set; }

    public int? ActualQueryCost { get; private set; }

    public static GraphQLBucketState Get(System.Text.Json.JsonDocument response)
    {
        if (!response.RootElement.TryGetProperty("extensions", out var extensions))
            return null;
        if (!extensions.TryGetProperty("cost", out var cost))
            return null;

        int requestedQueryCost = cost.GetProperty("requestedQueryCost").GetInt32();
        int? actualQueryCost = cost.TryGetProperty("actualQueryCost", out var actualQueryCostElt) && actualQueryCostElt.ValueKind != System.Text.Json.JsonValueKind.Null ? actualQueryCostElt.GetInt32() : null;//actual query cost is null if THROTTLED

        var throttleStatus = cost.GetProperty("throttleStatus");
        decimal maximumAvailable = throttleStatus.GetProperty("maximumAvailable").GetDecimal();
        decimal restoreRate = throttleStatus.GetProperty("restoreRate").GetDecimal();
        decimal currentlyAvailable = throttleStatus.GetProperty("currentlyAvailable").GetDecimal();

        return new GraphQLBucketState
        {
            MaxAvailable = (int)maximumAvailable,
            RestoreRate = (int)restoreRate,
            CurrentlyAvailable = (int)currentlyAvailable,    
            RequestedQueryCost = requestedQueryCost,
            ActualQueryCost = actualQueryCost,
        };
    }
}