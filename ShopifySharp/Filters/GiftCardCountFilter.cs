using Newtonsoft.Json;

namespace ShopifySharp.Filters;

public class GiftCardCountFilter : Parameterizable
{
    /// <summary>
    /// Restricts results to those with the given status. Known values are "enabled", "disabled".
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }
}