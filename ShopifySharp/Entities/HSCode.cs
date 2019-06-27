using Newtonsoft.Json;

namespace ShopifySharp
{
    public class HSCode : ShopifyObject
    {
        /// <summary>
        /// The two-digit code for the country where the inventory item was made.
        /// </summary>
        [JsonProperty("country_code_of_origin")]
        public string CountryCodeOfOrigin { get; set; }

        /// <summary>
        /// The general Harmonized System (HS) code for the inventory item. Used if a country-specific HS code is not available.
        /// </summary>
        [JsonProperty("harmonized_system_code")]
        public string HarmonizedSystemCode { get; set; }
    }
}
