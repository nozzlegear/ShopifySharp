using Newtonsoft.Json;

namespace ShopifySharp.Filters;

/// <summary>
/// A filter for retrieving a single discount code.
/// </summary>
public class PriceRuleDiscountCodeFilter : Parameterizable
{
    [JsonProperty("code")]
    public string Code { get; set; }
}