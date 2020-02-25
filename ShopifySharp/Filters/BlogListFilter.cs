using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class BlogListFilter : ListFilter<Blog>
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}