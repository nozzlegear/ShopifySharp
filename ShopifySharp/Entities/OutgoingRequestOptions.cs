using Newtonsoft.Json;

namespace ShopifySharp
{
    public class OutgoingRequestOptions
    {
        [JsonProperty("notify_customer")]
        public bool? NotifyCustomer { get; set; }
    }
}