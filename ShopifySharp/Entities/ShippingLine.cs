using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShippingLine
    {
        /// <summary>
        /// The carrier provided identifier.
        /// </summary>
        [JsonProperty("carrier_identifier")]
        public string CarrierIdentifier { get; set; }

        /// <summary>
        /// A reference to the shipping method.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The phone number used for the shipment.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The price of this shipping method.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// The discounted price of this shipping method.
        /// </summary>
        [JsonProperty("discounted_price")]
        public decimal? DiscountedPrice { get; set; }

        /// <summary>
        /// An ordered list of amounts allocated by discount applications. Each discount allocation is associated to a particular discount application.
        /// </summary>
        [JsonProperty("discount_allocations")]
        public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

        /// <summary>
        /// The source of the shipping method.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The title of the shipping method.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// A list of <see cref="TaxLine"/> objects, each of which details the taxes applicable to this <see cref="ShippingLine"/>.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }
    }
}
