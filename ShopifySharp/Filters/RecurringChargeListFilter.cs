using Newtonsoft.Json;

namespace ShopifySharp.Filters;

/// <summary>
/// Options for filtering lists of Recurring Charges. 
/// </summary>
public class RecurringChargeListFilter : Parameterizable
{
    /// <summary>
    /// Restrict results to after the specified ID.
    /// </summary>
    [JsonProperty("since_id")]
    public long? SinceId { get; set; }
}