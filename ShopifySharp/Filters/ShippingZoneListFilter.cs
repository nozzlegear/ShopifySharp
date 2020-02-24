using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Shipping Zones. 
    /// </summary>
    /// <remarks>
    /// This class does not implement or extend the IListFilter, because the endpoint does not have paginated results. 
    /// </remarks>
    public class ShippingZoneListFilter
    {
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        public IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}