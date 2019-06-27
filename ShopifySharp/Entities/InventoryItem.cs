using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ShopifySharp.Enums;
using ShopifySharp.Converters;

namespace ShopifySharp
{
    public class InventoryItem : ShopifyObject
    {
        /// <summary>
        /// The unique SKU (Stock Keeping Unit) of the inventory item.
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// Whether the inventory item is tracked. If true, then inventory quantity changes are tracked by Shopify.
        /// </summary>
        [JsonProperty("tracked")]
        public bool? Tracked { get; set; }

        /// <summary>
        /// The unit cost of the inventory item.
        /// </summary>
        [JsonProperty("cost")]
        public decimal? Cost { get; set; }

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

        /// <summary>
        /// An array of country-specific Harmonized System (HS) codes for the item. Used to determine duties when shipping the inventory item to certain countries.
        /// </summary>
        [JsonProperty("HarmonizedSystemCodes")]
        public IEnumerable<HSCode> HarmonizedSystemCodes { get; set; }

        /// <summary>
        /// The date and time when the product variant was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the product variant was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
