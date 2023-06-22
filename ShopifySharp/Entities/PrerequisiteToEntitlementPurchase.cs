using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteToEntitlementPurchase
    {
        [JsonProperty("prerequisite_amount")]
        public string PrerequisiteAmount { get; set; }
    }
}