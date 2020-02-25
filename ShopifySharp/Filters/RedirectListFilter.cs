using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Redirects.
    /// </summary>
    public class RedirectListFilter : ListFilter
    {
        /// <summary>
        /// Filters the result to those with the given path.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Filters the result to those with the given target.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
