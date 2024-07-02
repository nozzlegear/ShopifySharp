using Newtonsoft.Json;

namespace ShopifySharp;

public class DeliveryMethodBrandedPromise
{
    /// <summary>
    /// The name of the branded promise. For example: `Shop Promise`.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The handle of the branded promise. For example: `shop_promise`
    /// </summary>
    [JsonProperty("handle")]
    public string Handle { get; set; }
}
