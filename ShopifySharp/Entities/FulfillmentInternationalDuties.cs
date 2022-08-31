using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    public class FulfillmentInternationalDuties
    {
        /// <summary>
        /// The method of duties payment. Valid values:
        ///     DAP: Delivered at place.
        ///     DDP: Delivered duty paid.
        /// </summary>
        [JsonProperty("incoterm")]
        public string InternationalDuties { get; set; }

    }
}