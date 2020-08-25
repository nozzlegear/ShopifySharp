using Newtonsoft.Json;

namespace ShopifySharp
{
    public class AssignedLocation
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        [JsonProperty("address2")]
        public string Address2 { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("location_id")]
        public string LocationId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("province")]
        public string Province { get; set; }
        [JsonProperty("zip")]
        public string Zip { get; set; }

    }
}