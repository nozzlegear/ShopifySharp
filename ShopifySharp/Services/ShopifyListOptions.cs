using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyListOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Show customers created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public string CreatedAtMin { get; set; }

        /// <summary>
        /// Show customers created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public string CreatedAtMax { get; set; }

        /// <summary>
        /// Show customers last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public string UpdatedAtMin { get; set; }

        /// <summary>
        /// Show customers last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public string UpdatedAtMax { get; set; }
    }
}
