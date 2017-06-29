using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class ProductOption : ShopifyObject
    {
        /// <summary>
        /// The unique numeric identifier for the product.
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// The name of the option.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The order of the product variant in the list of product variants. 1 is the first position.
        /// </summary>
        [JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// The values for the options.
        /// </summary>
        [JsonProperty("values")]
        public IEnumerable<string> Values { get; set; }
    }
}
