using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify product.
    /// </summary>
    public class Checkout : ShopifyObject
    {
        /// <summary>
        /// The full recovery URL to be sent to a customer to recover their abandoned checkout.
        /// </summary>
        [JsonProperty("abandoned_checkout_url")]
        public string AbandonedCheckoutUrl { get; set; }
        
        /// <summary>
        /// The mailing address associated with the payment method.
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }
        
        /// <summary>
        /// Indicates whether or not the person who placed the order would like to receive email 
        /// updates from the shop. This is set when checking the "I want to receive occasional 
        /// emails about new products, promotions and other news" checkbox during checkout. 
        /// </summary>
        [JsonProperty("buyer_accepts_marketing")]
        public bool? BuyerAcceptsMarketing { get; set; }
        
        /// <summary>
        /// Unique identifier for a particular cart that is attached to a particular order.
        /// </summary>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }
        
        /// <summary>
        /// The date and time when the abandoned cart was completed. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("closed_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ClosedAt { get; set; }
        
        /// <summary>
        /// The date and time when the abandoned cart was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("completed_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CompletedAt { get; set; }
        
        /// <summary>
        /// The date and time when the abandoned cart was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }
        
        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        /// <summary>
        /// Information about the customer.
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
        
        /// <summary>
        /// The two or three-letter language code, optionally followed by a region modifier. Example values: en, en-CA. 
        /// </summary>
        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }
        
        /// <summary>
        /// The ID of the Shopify POS device that created the checkout.
        /// </summary>
        [JsonProperty("device_id")]
        public long? DeviceId { get; set; }
        
        /// <summary>
        /// Applicable discount codes that can be applied to the order. If no codes exist the value will default to blank. 
        /// </summary>
        [JsonProperty("discount_codes")]
        public IEnumerable<DiscountCode> DiscountCodes { get; set; }
        
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
        /// The URL for the page where the buyer landed when entering the shop.
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }
        
        /// <summary>
        /// A list of line item objects, each one containing information about an item in the order. 
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<CheckoutLineItem> LineItems { get; set; }
        
        /// <summary>
        /// The ID of the physical location where the checkout was processed.
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }
        
        /// <summary>
        /// The text of an optional note that a shop owner can attach to the order.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }
        
        /// <summary>
        /// The customer's phone number for receiving SMS notifications.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        
        /// <summary>
        /// The three-letter code (ISO 4217 format) of the currency that the customer used at checkout.
        /// </summary>
        [JsonProperty("presentment_currency")]
        public string PresentmentCurrency { get; set; }
        
        /// <summary>
        /// The website that the customer clicked on to come to the shop.
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }
        
        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
        
        /// <summary>
        /// An array of shipping line objects, each of which details the shipping methods used.
        /// </summary>
        [JsonProperty("shipping_lines")]
        public IEnumerable<ShippingLine> ShippingLines { get; set; }
        
        /// <summary>
        /// Where the checkout originated. Known values are: "web", "pos", "iphone", and "android"
        /// </summary>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }
        
        /// <summary>
        /// Price of the order before shipping and taxes
        /// </summary>
        [JsonProperty("subtotal_price")]
        public decimal? SubtotalPrice { get; set; }
        
        /// <summary>
        /// An array of tax line objects, each of which details the taxes applicable to the order. 
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }
        
        /// <summary>
        /// Whether taxes are included in the price.
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool? TaxesIncluded { get; set; }
        
        /// <summary>
        /// Unique identifier for a particular order.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        
        /// <summary>
        /// The total amount of the discounts to be applied to the price of the order.
        /// </summary>
        [JsonProperty("total_discounts")]
        public decimal? TotalDiscounts { get; set; }

        /// <summary>
        /// The total duties of the checkout in presentment currency.
        /// </summary>
        [JsonProperty("total_duties")]
        public decimal? TotalDuties { get; set; }

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
        /// The date and time when the abandoned cart was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        /// <summary>
        /// The ID of the user who created the checkout.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }
    }
}
