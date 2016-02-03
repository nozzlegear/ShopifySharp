using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Filters the results of <see cref="ShopifyScriptTagService.ListAsync(ShopifyScriptTagListOptions)"/>.
    /// </summary>
    public class ShopifyScriptTagListOptions : ShopifyListOptions
    {
        /// <summary>
        /// Returns only those <see cref="ShopifyScriptTag"/>s with the given <see cref="ShopifyScriptTag.Src"/> value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
