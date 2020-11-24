using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities
{
    public class FulfillmentOrderDestination
    {
        /// <summary>
        /// The ID of the fulfillment order destination.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The street address of the assigned location.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// An optional additional field for the street address of the assigned location.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the destination.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The company of the destination.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The country of the destination.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The email of the customer at the destination.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the customer at the destination.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the customer at the destination.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number of the customer at the destination.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The province of the destination.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The ZIP code of the destination.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
