using System;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public class GiftCardSearchFilter : ListFilter
    {
        /// <summary>
        /// The field and direction to order results by.
        /// Default: `disabled_at DESC`
        /// </summary>
        public string Order { get; set; }
        
        /// <summary>
        /// The text to search for.
        /// </summary>
        public string Query { get; set; }
        
        /// <summary>
        /// Show only certain fields, specified by a comma-separated list of field names.
        /// </summary>
        public string Fields { get; set; }
        
        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}