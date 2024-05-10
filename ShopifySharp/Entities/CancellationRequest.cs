using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify fulfillment cancellation request.
/// </summary>
public class CancellationRequest
{
    /// <summary>
    /// An optional reason for the cancellation request.
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }

}