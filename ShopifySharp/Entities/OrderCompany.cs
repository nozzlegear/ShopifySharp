using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a company and its location
    /// </summary>
    public class OrderCompany
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("location_id")]
        public long? LocationId { get; set; }
    }
}
