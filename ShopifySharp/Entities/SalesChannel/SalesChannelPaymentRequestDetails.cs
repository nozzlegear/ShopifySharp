using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel;

public class SalesChannelPaymentRequestDetails
{
    [JsonProperty("ip_address")]
    public string IpAddress { get; set; }

    [JsonProperty("accept_language")]
    public string AcceptLanguage { get; set; }

    [JsonProperty("user_agent")]
    public string UserAgent { get; set; }
}