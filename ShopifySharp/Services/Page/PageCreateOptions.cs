using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PageCreateOptions : Parameterizable
    {
        [JsonProperty("published")]
        public bool? Published { get; set; }
    }
}
