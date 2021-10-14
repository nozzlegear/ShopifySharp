using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ShopifySharp.Converters;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class LineItem : ShopifyObject
    {
        /// <summary>
        /// The amount available to fulfill. This is the quantity - max(refunded_quantity, fulfilled_quantity) - pending_fulfilled_quantity.
        /// </summary>
        [JsonProperty("fulfillable_quantity")]
        public int? FulfillableQuantity { get; set; }

        /// <summary>
        /// Service provider who is doing the fulfillment. Valid values are either "manual" or the name of the provider. eg: "amazon", "shipwire", etc.
        /// </summary>
        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

        /// <summary>
        /// The fulfillment status of this line item. Known values are 'fulfilled', 'null' and 'partial'.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// The weight of the item in grams.
        /// </summary>
        [JsonProperty("grams")]
        public long? Grams { get; set; }

        /// <summary>
        /// The price of the item before discounts have been applied.
        /// </summary>
        /// <remarks>Shopify returns this value as a string.</remarks>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product in the fulfillment. Can be null if the original product associated with the order is deleted at a later date
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// The number of products that were purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// States whether or not the fulfillment requires shipping.
        /// </summary>
        [JsonProperty("requires_shipping")]
        public bool? RequiresShipping { get; set; }

        /// <summary>
        /// A unique identifier of the item in the fulfillment.
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// The title of the product.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The id of the product variant. Can be null if the product purchased is not a variant.
        /// </summary>
        [JsonProperty("variant_id")]
        public long? VariantId { get; set; }

        /// <summary>
        /// The title of the product variant. Can be null if the product purchased is not a variant.
        /// </summary>
        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }

        /// <summary>
        /// The name of the product variant.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the supplier of the item.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// States whether the order used a gift card.
        /// </summary>
        [JsonProperty("gift_card")]
        public bool? GiftCard { get; set; }

        /// <summary>
        /// States whether or not the product was taxable.
        /// </summary>
        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }

        /// <summary>
        /// An array of <see cref="TaxLine"/> objects, each of which details the taxes applicable to this <see cref="LineItem"/>.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// The payment gateway used to tender the tip, such as shopify_payments. Present only on tips.
        /// </summary>
        [JsonProperty("tip_payment_gateway")]
        public string TipPaymentGateway { get; set; }

        /// <summary>
        /// The payment method used to tender the tip, such as Visa. Present only on tips.
        /// </summary>
        [JsonProperty("tip_payment_method")]
        public string TipPaymentMethod { get; set; }

        /// <summary>
        /// The total discount amount applied to this line item. This value is not subtracted in the line item price.
        /// </summary>
        [JsonProperty("total_discount")]
        public decimal? TotalDiscount { get; set; }

        /// <summary>
        /// The total discount applied to the line item in shop and presentment currencies.
        /// </summary>
        [JsonProperty("total_discount_set")]
        public PriceSet TotalDiscountSet { get; set; }

        /// <summary>
        /// An ordered list of amounts allocated by discount applications. Each discount allocation is associated to a particular discount application.
        /// </summary>
        [JsonProperty("discount_allocations")]
        public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

        /// <summary>
        /// An array of custom information for an item that has been added to the cart.
        /// Often used to provide product customization options.
        /// An array of <see cref="TaxLine"/> objects, each of which details the taxes applicable to this <see cref="LineItem"/>.
        /// </summary>
        /// <remarks>
        /// See https://github.com/nozzlegear/ShopifySharp/pull/461 for why the custom converter is required
        /// </remarks>
        [JsonProperty("properties")]
        [JsonConverter(typeof(NullOnErrorConverter))]
        public IEnumerable<LineItemProperty> Properties { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("variant_inventory_management")]
        public string VariantInventoryManagement { get; set; }

        /// <summary>
        /// This property is undocumented by Shopify.
        /// </summary>
        [JsonProperty("product_exists")]
        public bool? ProductExists { get; set; }

        /// <summary>
        /// The price of the line item in shop and presentment currencies
        /// </summary>
        [JsonProperty("price_set")]
        public PriceSet PriceSet { get; set; }

        /// <summary>
        /// A list of duty objects, each containing information about a duty on the line item
        /// </summary>
        [JsonProperty("duties")]
        public IEnumerable<LineItemDuty> Duties { get; set; }

        /// <summary>
        /// The location of the line item's fulfillment origin.
        /// </summary>
        [JsonProperty("origin_location")]
        public LineItemOriginLocation OriginLocation { get; set; }

        /// <summary>
        /// A unique identifier for a quantity of items within a single fulfillment. An order can have multiple fulfillment line items.
        /// </summary>
        [JsonProperty("fulfillment_line_item_id")]
        public long? FulfillmentLineItemId { get; set; }
    }
}
