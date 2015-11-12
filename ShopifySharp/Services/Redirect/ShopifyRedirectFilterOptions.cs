using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Filters <see cref="ShopifyRedirectService.ListAsync(ShopifyListOptions)"/> results.
    /// </summary>
    public class ShopifyRedirectFilterOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// Restrict results to after the given id.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId {get; set;}

        /// <summary>
        /// An optional parameter that filters the result to redirects with the given path.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// An optional parameter that filters the result to redirects with the given target.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
