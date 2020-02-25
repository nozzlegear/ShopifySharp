using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class ScriptTagCountFilter : CountFilter
    {
        /// <summary>
        /// Restricts results to those with the given src value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}