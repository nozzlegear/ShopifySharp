using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Recurring Charges. 
    /// </summary>
    /// <remarks>
    /// This class does not implement or extend the IListFilter, because the endpoint does not have paginated results. 
    /// </remarks>
    public class RecurringChargeListFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        public IEnumerable<KeyValuePair<string, object>> ToQueryParams()
        {
            throw new NotImplementedException();
        }
    }
}