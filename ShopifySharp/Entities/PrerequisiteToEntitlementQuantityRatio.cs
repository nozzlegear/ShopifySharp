using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteToEntitlementQuantityRatio
    {
        [JsonProperty("prerequisite_quantity")]
        public int prerequisite_quantity { get; set; }

        [JsonProperty("entitled_quantity")]
        public int entitled_quantity { get; set; }
    }
}