using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteToEntitlementQuantityRatio
    {
        [JsonProperty("prerequisite_quantity")]
        public int? PrerequisiteQuantity { get; set; }

        [JsonProperty("entitled_quantity")]
        public int? EntitledQuantity { get; set; }
    }
}
