using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public abstract class ShopifyObject
    {
        /// <summary>
        /// The object's unique id.
        /// </summary>
        /// <remarks>
        /// Some object ids are longer than the max int32 value. Using long instead.
        /// Marked as nullable due to issues I've run into when trying to create a resource. If Id is present when creating, 
        /// Shopify will try to find that resource. By default it's set to 0 when not null, so the resource won't exist and 
        /// Shopify will return a 404 Not Found. This is most obvious when creating a customer with a <see cref="ShopifyAddress"/> 
        /// and the <see cref="ShopifyAddress"/> Id set to 0.
        /// </remarks>
        [JsonProperty("id")]
        public long? Id { get; set; }
    }
}
