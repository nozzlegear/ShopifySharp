using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class Address: ShopifyObject
    {
        /// <summary>
        /// The mailing address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// An additional field for the mailing address.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The two-letter country code corresponding to the country.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The normalized country name.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Indicates whether this address is the default address.
        /// </summary>
        [JsonProperty("default")]
        public bool Default { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The province or state name
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The two-letter province or state code.
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// The ZIP or postal code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
