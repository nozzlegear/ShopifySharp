using Newtonsoft.Json;

namespace ShopifySharp;

public class DeliveryMethodAdditionalInformation
{
    /// <summary>
    /// instructions: The delivery instructions to follow when performing the delivery.
    /// </summary>
    [JsonProperty("instructions")]
    public string Instructions { get; set; }

    /// <summary>
    /// The phone number to contact when performing the delivery.
    /// </summary>
    [JsonProperty("phone")]
    public string Phone { get; set; }
}
