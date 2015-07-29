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
        /// <remarks>Some object ids are longer than the max int32 value. Using long instead.</remarks>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
