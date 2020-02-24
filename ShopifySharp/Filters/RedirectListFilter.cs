using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Redirects.
    /// </summary>
    public class RedirectListFilter : ListFilter<Redirect>
    {
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

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}
