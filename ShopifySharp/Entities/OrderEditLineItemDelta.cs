using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify line item addition or removal.
/// The Id of this object is the Id of the line item being edited
/// </summary>
public class OrderEditLineItemDelta : ShopifyObject
{
    /// <summary>
    /// The quantiy added or removed
    /// </summary>
    [JsonProperty("delta")]
    public int? Delta { get; set; }
}