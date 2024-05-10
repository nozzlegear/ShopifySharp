using Newtonsoft.Json;

namespace ShopifySharp;

public class MerchantRequest
{
    /// <summary>
    /// The message returned by the merchant, if any.
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// The request options returned by the merchant, if any.
    /// </summary>
    [JsonProperty("request_options")]
    public MerchantRequestOptions RequestOptions { get; set; }

    /// <summary>
    /// The kind of request. Known valid values: "fulfillment_request", "cancellation_request", or "legacy_fulfill_request".
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }
}