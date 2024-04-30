using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment service.
    /// </summary>
    public class FulfillmentServiceEntity : ShopifyObject
    {
        /// <summary>
        /// The name of the fulfillment service as seen by merchants and their customers.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// States the URL endpoint that Shopify needs to retrieve inventory and tracking updates.
        /// This field is necessary if either inventory_management or tracking_support is set to "true".
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Specifies the format of the API output. Valid values are "json" and "xml".
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// A human-friendly unique string for the fulfillment service generated from its title.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// States if the fulfillment service tracks product inventory and provides updates to Shopify.
        /// </summary>
        [JsonProperty("inventory_management")]
        public bool? InventoryManagement { get; set; }

        /// <summary>
        /// The unique identifier of the location tied to the fulfillment service
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// A unique identifier for the fulfillment service provider.
        /// </summary>
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        /// <summary>
        /// States if the fulfillment service requires products to be physically shipped.
        /// </summary>
        [JsonProperty("requires_shipping_method")]
        public bool? RequiresShippingMethod { get; set; }
                
        /// <summary>
        /// States if the fulfillment service allows products to have more than 1 shipping location
        /// </summary>
        [JsonProperty("permits_sku_sharing")]
        public bool? PermitsSkuSharing { get; set; }

        /// <summary>
        /// States if the fulfillment service provides tracking numbers for packages.
        /// </summary>
        [JsonProperty("tracking_support")]
        public bool? TrackingSupport { get; set; }


        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("include_pending_stock")]
        public bool? IncludePendingStock { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Whether the fulfillment service wants to register for APIs related to fulfillment orders.
        /// </summary>
        [JsonProperty("fulfillment_orders_opt_in")]
        [Obsolete("https://shopify.dev/changelog/deprecation-of-the-fulfillmentservice-fulfillmentordersoptin-field")]
        public bool? FulfillmentOrdersOptIn { get; set; }
    }
}