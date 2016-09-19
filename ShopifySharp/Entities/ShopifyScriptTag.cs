using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing remote javascript tags that are loaded into the pages of a shop's storefront.
    /// </summary>
    public class ShopifyScriptTag: ShopifyObject
    {
        /// <summary>
        /// The date and time when the <see cref="ShopifyScriptTag"/> was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// DOM event which triggers the loading of the script. The only known value is 'onload'.
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Specifies the location of the ScriptTag.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// The date and time when the <see cref="ShopifyScriptTag"/> was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
