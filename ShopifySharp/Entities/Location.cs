using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a physical store location.
    /// </summary>
    public class Location : ShopifyObject
    {
        /// <summary>
        /// The name of the location.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The zip or postal code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The city the location is in.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The province the location is in.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The country the location is in.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The name of the country the location is in.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// The phone number of the location. Can contain special chars like - and +.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The date and time when the location was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the location was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
