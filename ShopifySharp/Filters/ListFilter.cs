using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ListFilter : CountFilter
    {
        /// <summary>
        /// An optional array of order ids to retrieve.
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Limit the amount of results. Default is 50, max is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// An optional, comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// An optional field name to order by, followed by either ' asc' or ' desc'.
        /// For example, 'created_at asc'
        /// Not all fields are supported...
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

    }
}
