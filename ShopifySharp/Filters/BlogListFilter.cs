using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class BlogListFilter : ListFilter
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}