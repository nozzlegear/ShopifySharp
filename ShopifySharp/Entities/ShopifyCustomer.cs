using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyCustomer : ShopifyObject
    {
        /// <summary>
        /// Indicates whether the customer has consented to be sent marketing material via email.
        /// </summary>
        [JsonProperty("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        /// <summary>
        /// A list of addresses for the customer.
        /// </summary>
        [JsonProperty("addresses")]
        public IEnumerable<ShopifyAddress> Addresses { get; set; }

        /// <summary>
        /// The date and time when the customer was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The default address for the customer.
        /// </summary>
        [JsonProperty("default_address")]
        public ShopifyAddress DefaultAddress { get; set; }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Additional metadata about the customer. Note: This should only be used when creating or updating a <see cref="ShopifyCustomer"/>, as
        /// Shopify will never return <see cref="ShopifyCustomer"/> metafields. Instead, you need to query metafields with <see cref="ShopifyMetaFieldService"/>.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<ShopifyMetaField> Metafields { get; set; }

        /// <summary>
        /// The customer's identifier used with Multipass login
        /// </summary>
        [JsonProperty("multipass_identifier")]
        public string MultipassIdentifier { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The id of the customer's last order.
        /// </summary>
        /// <remarks>Property can be null or longer than max int32 value. Set to nullable long instead.</remarks>
        [JsonProperty("last_order_id")]
        public long? LastOrderId { get; set; }

        /// <summary>
        /// The name of the customer's last order. This is directly related to the Order's name field.
        /// </summary>
        [JsonProperty("last_order_name")]
        public string LastOrderName { get; set; }

        /// <summary>
        /// A note about the customer.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The number of orders associated with this customer.
        /// </summary>
        [JsonProperty("orders_count")]
        public int OrdersCount { get; set; }

        /// <summary>
        /// The state of the customer in a shop. Valid values are 'disabled', 'decline', 'invited' and 'enabled'.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Tags are additional short descriptors formatted as a string of comma-separated values.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Indicates whether the customer should be charged taxes when placing orders. 
        /// </summary>
        [JsonProperty("tax_exempt")]
        public bool TaxExempt { get; set; }

        /// <summary>
        /// The total amount of money that the customer has spent at the shop.
        /// </summary>
        /// <remarks>The Shopify API actually returns this value as a string, but Json.Net can automatically convert to double.</remarks>
        [JsonProperty("total_spent")]
        public double TotalSpent { get; set; }

        /// <summary>
        /// The date and time when the customer information was updated. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// States whether or not the email address has been verified.
        /// </summary>
        [JsonProperty("verified_email")]
        public bool VerifiedEmail { get; set; }
    }
}
