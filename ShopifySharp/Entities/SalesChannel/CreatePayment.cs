using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel;

public class CreatePayment
{
    [JsonProperty("request_details")]
    public SalesChannelPaymentRequestDetails SalesChannelPaymentRequestDetails { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("session_id")]
    public string SessionId { get; set; }

    [JsonProperty("unique_token")]
    public string UniqueToken { get; set; }
}