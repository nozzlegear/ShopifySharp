using Newtonsoft.Json;

namespace ShopifySharp;

public class OutgoingFulfillmentRequestOptions
{
    [JsonProperty("notify_customer")]
    public bool? NotifyCustomer { get; set; }
}