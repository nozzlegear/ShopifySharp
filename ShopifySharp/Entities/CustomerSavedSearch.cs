using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CustomerSavedSearch : ShopifyObject
    {
        /// <summary>
        /// The name given by the shop owner to the customer saved search
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// The set of conditions that determines which customers will be returned by the saved search
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }
        
        /// <summary>
        /// The date and time when the customer saved search was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        /// <summary>
        /// The date and time when the customer saved search was updated. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}