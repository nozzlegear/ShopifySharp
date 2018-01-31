using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify product.
    /// </summary>
    public class Checkout : ShopifyObject
    {
        /// <summary>
        /// Unique identifier for a particular order.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Unique identifier for a particular cart that is attached to a particular order.
        /// </summary>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The payment gateway used.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Indicates whether or not the person who placed the order would like to receive email 
        /// updates from the shop. This is set when checking the "I want to receive occasional 
        /// emails about new products, promotions and other news" checkbox during checkout. 
        /// Valid values are "true" and "false."
        /// </summary>
        [JsonProperty("buyer_accepts_marketing")]
        public bool? BuyerAcceptsMarketing { get; set; }

        /// <summary>
        /// The date and time when the abandoned cart was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the abandoned cart was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The URL for the page where the buyer landed when entering the shop.
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        /// <summary>
        /// The text of an optional note that a shop owner can attach to the order.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Extra information that is added to the order.
        /// </summary>
        [JsonProperty("note_attributes")]
        public IEnumerable<NoteAttribute> NoteAttributes { get; set; }

        /// <summary>
        /// The website that the customer clicked on to come to the shop.
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        /// <summary>
        /// An array of  shipping_line  objects, each of which details the shipping methods used. Each shipping_line has the following properties: 
        ///  code: A reference to the shipping method.
        ///  price: The price of this shipping method.
        ///  source: 
        ///  title: 
        /// </summary>
        [JsonProperty("shipping_lines")]
        public IEnumerable<ShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Price of the order before shipping and taxes
        /// </summary>
        [JsonProperty("subtotal_price")]
        public decimal? SubtotalPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool? TaxesIncluded { get; set; }

        /// <summary>
        /// The total amount of the discounts to be applied to the price of the order.
        /// </summary>
        [JsonProperty("total_discounts")]
        public decimal? TotalDiscounts { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order.
        /// </summary>
        [JsonProperty("total_line_items_price")]
        public decimal? TotalLineItemsPrice { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order, taxes and discounts included.
        /// </summary>
        [JsonProperty("total_price")]
        public decimal? TotalPrice { get; set; }

        /// <summary>
        /// The sum of all the taxes applied to the line items in the order.
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The sum of all the weights of the line items in the order, in grams.
        /// </summary>
        [JsonProperty("total_weight")]
        public decimal? TotalWeight { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The date and time when the abandoned cart was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("completed_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The date and time when the abandoned cart was completed. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("closed_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ClosedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("source_identifier")]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// A list of line item objects, each one containing information about an item in the order. Each  line_item  object has the following properties: 
        ///  fulfillment_service: Service provider who is doing the fulfillment.
        ///  fulfillment_status: How far along an order is in terms line items fulfilled.Valid values are: fulfilled, null or partial.
        ///  grams: The weight of the item in grams.
        ///  price: The price of the item.
        ///  product_id: The unique numeric identifier for the product in the fulfillment.
        ///  quantity: The number of products that were purchased.
        ///  requires_shipping: States whether or not the fulfillment requires shipping. Values are: true or false.
        ///  sku: A unique identifier of the item in the fulfillment.
        ///  title: The title of the product.
        ///  variant_id: The id of the product variant.
        ///  variant_title: The title of the product variant.
        ///  vendor: The name of the supplier of the item.
        ///  name: The name of the product variant.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<CheckoutLineItem> LineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Applicable discount codes that can be applied to the order. If no codes exist the value will default to blank. 
        /// A Discount code will include the following fields: •amount: The amount of the discount.
        ///  code: The discount code.
        ///  type: The type of discount.Can be one of: "percentage", "shipping", "fixed_amount" (default).
        /// </summary>
        [JsonProperty("discount_codes")]
        public IEnumerable<DiscountCode> DiscountCodes { get; set; }

        /// <summary>
        /// The full recovery URL to be sent to a customer to recover their abandoned checkout.
        /// </summary>
        [JsonProperty("abandoned_checkout_url")]
        public string AbandonedCheckoutUrl { get; set; }

        /// <summary>
        /// An array of  tax_line  objects, each of which details the taxes applicable to the order. Each  tax_line  has the following properties: 
        ///  price: The amount of tax to be charged.
        ///  rate: The rate of tax to be applied.
        ///  title: The name of the tax.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Where the checkout originated. Possible values are: "web", "pos", "iphone", and "android"
        /// </summary>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// The mailing address associated with the payment method. It has the following properties: 
        ///  address1: The street address of the billing address.
        ///  address2: An optional additional field for the street address of the billing address.
        ///  city: The city of the billing address.
        ///  company: The company of the person associated with the billing address.
        ///  country: The name of the country of the billing address.
        ///  country_code: The two-letter code (ISO 3166-1 alpha-2 two-letter country code) for the country of the billing address.
        ///  first_name: The first name of the person associated with the payment method.
        ///  last_name: The last name of the person associated with the payment method.
        ///  latitude: The latitude of the billing address.
        ///  longitude: The longitude of the billing address.
        ///  name: The full name of the person associated with the payment method.
        ///  phone: The phone number at the billing address.
        ///  province: The name of the state or province of the billing address.
        ///  province_code: The two-letter abbreviation of the state or province of the billing address.
        ///  zip:The zip or postal code of the billing address.
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// A <see cref="ShopifySharp.Customer"/> object containing information about the customer.
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
        
    }
}
