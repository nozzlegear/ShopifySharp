using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="GiftCardService.ListAsync(GiftCardFilter)"/> results.
    /// </summary>
    public class GiftCardFilter : ListFilter
    {
        /// <summary>
        /// The status of gift card to retrieve. Known values are "enabled", "disabled".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
