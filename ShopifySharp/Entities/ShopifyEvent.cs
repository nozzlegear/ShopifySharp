using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Entities
{    /// <summary>
     /// An object representing a Shopify event.
     /// </summary>
    public class ShopifyEvent
    {
        /// <summary>
        /// Shopify event id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Shopify event subject id
        /// </summary>
        [JsonProperty("subject_id")]
        public long SubjectId { get; set; }

        /// <summary>
        /// Event created at date time
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Shopify subject type
        /// </summary>
        [JsonProperty("subject_type")]
        public ShopifyEventSubjectType SubjectType { get; set; }
        
        /// <summary>
        /// Event message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        // TODO: add all properties
    }
}
