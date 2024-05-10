using Newtonsoft.Json;

namespace ShopifySharp;

public class PresentmentPrice
{
    /// <summary>
    /// The price of the product variant.
    /// </summary>
    [JsonProperty("price")]
    public Price Price { get; set; }

    /// <summary>
    /// The competitors prices for the same item.
    /// </summary>
    [JsonProperty("compare_at_price")]
    public Price CompareAtPrice { get; set; }
}