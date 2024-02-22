using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyPaymentsDisputeEvidenceAddress
    {
        /// <summary>
        /// The street address of the shipping / billing location.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address. Typically the number of the apartment, suite, or unit.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the shipping / billing location.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The zip code of the shipping / billing location.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// (Required) The two-letter country code (ISO 3166-1 alpha-2 format) of the shipping / billing location.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The province of the shipping / billing location.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The province code of the shipping / billing location.
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
    }
}
