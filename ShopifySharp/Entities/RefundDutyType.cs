using Newtonsoft.Json;

namespace ShopifySharp;

public class RefundDutyType
{
    [JsonProperty("duty_id")]
    public long? DutyId { get; set; }

    [JsonProperty("refund_type")]
    public string RefundType { get; set; }
}