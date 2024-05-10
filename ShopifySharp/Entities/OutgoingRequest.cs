using System;
using Newtonsoft.Json;

namespace ShopifySharp;

public class OutgoingRequest
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
    public OutgoingFulfillmentRequestOptions RequestOptions { get; set; }

    [JsonProperty("sent_at")]
    public DateTimeOffset? SentAt { get; set; }

    /// <summary>
    /// The kind of request. Known valid values: "fulfillment_request", "cancellation_request", or "legacy_fulfill_request".
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }
}