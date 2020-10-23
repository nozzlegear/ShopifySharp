using Newtonsoft.Json;

namespace ShopifySharp
{
    public class AssignedLocation
    {
        /// <summary>
        ///  The street address of the assigned location.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// An optional additional field for the street address of the assigned location.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the assigned location.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The two-letter code for the country of the assigned location.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The ID of the assigned location.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// The name of the assigned location.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the assigned location.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The province of the assigned location.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        ///  The ZIP code of the assigned location.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}