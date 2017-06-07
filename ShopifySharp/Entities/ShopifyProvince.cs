using Newtonsoft.Json;

namespace ShopifySharp.Entities
{
    /// <summary>
    /// Represents a Shopify State or Province
    /// </summary>
    /// <seealso cref="ShopifySharp.ShopifyObject" />
    public class ShopifyProvince : ShopifyObject
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The standard abbreviation for the state or province.
        /// </value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The unique numeric identifier for the country.
        /// </value>
        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        /// <summary>
        /// The object's unique id.
        /// </summary>
        /// <remarks>
        /// Some object ids are longer than the max int32 value. Using long instead.
        /// Marked as nullable due to issues I've run into when trying to create a resource. If Id is present when creating,
        /// Shopify will try to find that resource. By default it's set to 0 when not null, so the resource won't exist and
        /// Shopify will return a 404 Not Found. This is most obvious when creating a customer with a <see cref="ShopifyAddress" />
        /// and the <see cref="ShopifyAddress" /> Id set to 0.
        /// </remarks>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The full name of the state or province.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the shipping zone identifier.
        /// </summary>
        /// <value>
        /// The unique numeric identifier for the shipping zone the province belongs to.
        /// </value>
        [JsonProperty("shipping_zone_id")]
        public long ShippingZoneId { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>
        /// The national sales tax rate to be applied to orders made by customers from that province or state.
        /// </value>
        [JsonProperty("tax")]
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or sets the name of the tax.
        /// </summary>
        /// <value>
        /// The name of the tax for that province or state.
        /// </value>
        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        /// <summary>
        /// Gets or sets the type of the tax.
        /// </summary>
        /// <value>
        /// Compounded sales tax. For example, the Canadian HST (also known as, the "Harmonized Sales tax") is a compounded sales tax of both PST and GST.
        /// </value>
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// Gets or sets the tax percentage.
        /// </summary>
        /// <value>
        /// The province or state's tax in percent format.
        /// </value>
        [JsonProperty("tax_percentage")]
        public decimal TaxPercentage { get; set; }
    }
}
