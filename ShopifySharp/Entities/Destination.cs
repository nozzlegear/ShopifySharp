using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// This object is undocumented by Shopify.
    /// An object representing a Shopify fulfillment's destination.
    /// </summary>
    public class Destination : ShopifyObject
    {
        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
    }
}
