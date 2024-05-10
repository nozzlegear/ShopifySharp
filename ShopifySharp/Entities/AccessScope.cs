using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An object representing an access scope
/// </summary>
public class AccessScope
{
    /// <summary>
    /// The scope's handle, such as "read_orders", "write_products", etc...
    /// </summary>
    [JsonProperty("handle")]
    public string Handle { get; set; }
}