using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteQuantityRange
    {
        [JsonProperty("greater_than_or_equal_to")]
        public int greater_than_or_equal_to { get; set; }
    }
}