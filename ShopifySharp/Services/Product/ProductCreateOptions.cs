using Newtonsoft.Json;

namespace ShopifySharp
{
    public class ProductCreateOptions : Parameterizable
    {
        [JsonProperty("published")]
        public bool? Published { get; set; }
    }
}
