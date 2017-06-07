using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Entities
{
    /// <summary>
    /// Represents a country in Shopify
    /// </summary>
    /// <seealso cref="ShopifySharp.ShopifyObject" />
    public class ShopifyCountry : ShopifyObject
    {

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The ISO 3166-1 alpha-2 two-letter country code for the country. The code for a given country will be the same as the code for the same country in another shop.
        /// </value>
        [JsonProperty("code")]
        public string Code { get; set; }


        /// <summary>
        /// The object's unique id.
        /// </summary>
        /// <remarks>
        /// The unique numeric identifier for the country. 
        /// It is important to note that the id for a given country in one shop will not be the same as the id for the same country in another shop.        
        /// </remarks>
        [JsonProperty("id")]
        public long Id { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The full name of the country, in English.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provinces")]
        public IEnumerable<ShopifyProvince> Provinces { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>
        /// The national sales tax rate to be applied to orders made by customers from that country.
        /// </value>
        [JsonProperty("tax")]
        public decimal Tax { get; set; }
    }
}
