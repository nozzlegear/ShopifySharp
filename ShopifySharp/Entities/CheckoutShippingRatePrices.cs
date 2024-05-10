using Newtonsoft.Json;

namespace ShopifySharp;

public class CheckoutShippingRatePrices
{
    [JsonProperty("totalTax")]
    public string TotalTax { get; set; }

    [JsonProperty("totalPrice")]
    public string TotalPrice { get; set; }

    [JsonProperty("subtotalPrice")]
    public string SubtotalPrice { get; set; }
}