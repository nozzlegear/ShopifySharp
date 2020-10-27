using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify order.
    /// </summary>
    public class Order : ShopifyObject
    {
        /// <summary>
        /// Unique identifier of the app who created the order.
        /// </summary>
        [JsonProperty("app_id")]
        public long? AppId { get; set; }

        /// <summary>
        /// The mailing address associated with the payment method. This address is an optional field that will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The IP address of the browser used by the customer when placing the order.
        /// </summary>
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        /// <summary>
        /// Indicates whether or not the person who placed the order would like to receive email updates from the shop.
        /// This is set when checking the "I want to receive occasional emails about new products, promotions and other news" checkbox during checkout.
        /// </summary>
        [JsonProperty("buyer_accepts_marketing")]
        public bool? BuyerAcceptsMarketing { get; set; }

        /// <summary>
        /// The reason why the order was cancelled. If the order was not cancelled, this value is null. Known values are "customer", "fraud", "inventory" and "other".
        /// </summary>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// The date and time when the order was cancelled. If the order was not cancelled, this value is null.
        /// </summary>
        [JsonProperty("cancelled_at")]
        public DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// Unique identifier for a particular cart that is attached to a particular order.
        /// </summary>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        /// <summary>
        /// A <see cref="ShopifySharp.ClientDetails"/> object containing information about the client.
        /// </summary>
        [JsonProperty("client_details")]
        public ClientDetails ClientDetails { get; set; }

        /// <summary>
        /// The date and time when the order was closed. If the order was not clsoed, this value is null.
        /// </summary>
        [JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        /// <summary>
        /// The date and time when the order was created in Shopify.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A <see cref="ShopifySharp.Customer"/> object containing information about the customer. This value may be null if the order was created through Shopify POS.
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// The two or three letter language code, optionally followed by a region modifier. Example values could be 'en', 'en-CA', 'en-PIRATE'.
        /// </summary>
        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }

        /// <summary>
        /// The unique numeric identifier of the POS device used.
        /// </summary>
        [JsonProperty("device_id")]
        public long? DeviceId { get; set; }

        /// <summary>
        /// Applicable discount codes that can be applied to the order.
        /// </summary>
        [JsonProperty("discount_codes")]
        public IEnumerable<DiscountCode> DiscountCodes { get; set; }

        /// <summary>
        /// An ordered list of amounts allocated by discount applications. Each discount allocation is associated to a particular discount application.
        /// </summary>
        [JsonProperty("discount_applications")]
        public IEnumerable<DiscountApplication> DiscountApplications { get; set; }

        /// <summary>
        /// The order's email address. Note: On and after 2015-11-03, you should be using <see cref="ContactEmail"/> to refer to the customer's email address.
        /// Between 2015-11-03 and 2015-12-03, updates to an order's email will also update the customer's email. This is temporary so apps can be migrated over to
        /// doing customer updates rather than order updates to change the contact email. After 2015-12-03, updating updating an order's email will no longer update
        /// the customer's email and apps will have to use the customer update endpoint to do so.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The financial status of an order. Known values are "authorized", "paid", "pending", "partially_paid", "partially_refunded", "refunded" and "voided".
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        /// <summary>
        /// An array of <see cref="Fulfillment"/> objects for this order.
        /// </summary>
        [JsonProperty("fulfillments")]
        public IEnumerable<Fulfillment> Fulfillments { get; set; }

        /// <summary>
        /// The fulfillment status for this order. Known values are 'fulfilled', 'null' and 'partial'.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Tags are additional short descriptors, commonly used for filtering and searching, formatted as a string of comma-separated values.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// The URL for the page where the buyer landed when entering the shop.
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        /// <summary>
        /// An array of <see cref="LineItem"/> objects, each one containing information about an item in the order.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<LineItem> LineItems { get; set; }

        /// <summary>
        /// The unique numeric identifier for the physical location at which the order was processed. Only present on orders processed at point of sale.
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// The customer's order name as represented by a number, e.g. '#1001'.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// Numerical identifier unique to the shop. A number is sequential and starts at 1000.
        /// </summary>
        [JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// A unique numeric identifier for the order. This one is used by the shop owner and customer.
        /// This is different from the id property, which is also a unique numeric identifier for the order, but used for API purposes.
        /// </summary>
        [JsonProperty("order_number")]
        public int? OrderNumber { get; set; }

        /// <summary>
        /// The URL pointing to the order status web page. The URL will be null unless the order was created from a checkout.
        /// </summary>
        [JsonProperty("order_status_url")]
        public string OrderStatusUrl { get; set; }

        /// <summary>
        /// The list of all payment gateways used for the order.
        /// </summary>
        [JsonProperty("payment_gateway_names")]
        public IEnumerable<string> PaymentGatewayNames { get; set; }

        /// <summary>
        /// The date that the order was processed at.
        /// </summary>
        [JsonProperty("processed_at")]
        public DateTimeOffset? ProcessedAt { get; set; }

        /// <summary>
        /// The type of payment processing method. Known values are 'checkout', 'direct', 'manual', 'offsite', 'express', 'free' and 'none'.
        /// </summary>
        [JsonProperty("processing_method")]
        public string ProcessingMethod { get; set; }

        /// <summary>
        /// The website that the customer clicked on to come to the shop.
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        /// <summary>
        /// The list of <see cref="Refund"/> objects applied to the order
        /// </summary>
        [JsonProperty("refunds")]
        public IEnumerable<Refund> Refunds { get; set; }

        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// An array of <see cref="ShippingLine"/> objects, each of which details the shipping methods used.
        /// </summary>
        [JsonProperty("shipping_lines")]
        public IEnumerable<ShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Where the order originated. May only be set during creation, and is not writeable thereafter.
        /// Orders created via the API may be assigned any string of your choice except for "web", "pos", "iphone", and "android".
        /// Default is "api".
        /// </summary>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// Price of the order before shipping and taxes
        /// </summary>
        [JsonProperty("subtotal_price")]
        public decimal? SubtotalPrice { get; set; }

        /// <summary>
        /// An array of <see cref="TaxLine"/> objects, each of which details the total taxes applicable to the order.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// States whether or not taxes are included in the order subtotal.
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool? TaxesIncluded { get; set; }

        /// <summary>
        /// States whether this is a test order.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Unique identifier for a particular order.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The total amount of the discounts applied to the price of the order.
        /// </summary>
        [JsonProperty("total_discounts")]
        public decimal? TotalDiscounts { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order.
        /// </summary>
        [JsonProperty("total_line_items_price")]
        public decimal? TotalLineItemsPrice { get; set; }

        /// <summary>
        /// The sum of all the tips in the order.
        /// </summary>
        [JsonProperty("total_tip_received")]
        public decimal? TotalTipReceived { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order, with taxes and discounts included (must be positive).
        /// </summary>
        [JsonProperty("total_price")]
        public decimal? TotalPrice { get; set; }

        /// <summary>
        /// The sum of all the taxes applied to the order (must be positive).
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The sum of all the weights of the line items in the order, in grams.
        /// </summary>
        [JsonProperty("total_weight")]
        public long? TotalWeight { get; set; }

        /// <summary>
        /// The date and time when the order was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The unique numerical identifier for the user logged into the terminal at the time the order was processed at. Only present on orders processed at point of sale.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// An array of <see cref="Transaction"/> objects that detail all of the transactions in
        /// this order.
        /// </summary>
        [JsonProperty("transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }

        /// <summary>
        /// Additional metadata about the <see cref="Order"/>. Note: This is not naturally returned with a <see cref="Order"/> response, as
        /// Shopify will not return <see cref="Order"/> metafields unless specified. Instead, you need to query metafields with <see cref="MetaFieldService"/>. 
        /// Uses include: Creating, updating, & deserializing webhook bodies that include them.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<MetaField> Metafields { get; set; }

        /// <summary>
        /// The current total duties charged on the order in shop and presentment currencies.
        /// </summary>
        [JsonProperty("current_total_duties_set")]
        public PriceSet CurrentTotalDutiesSet { get; set; }

        /// <summary>
        /// The original total duties charged on the order in shop and presentment currencies.
        /// </summary>
        [JsonProperty("original_total_duties_set")]
        public PriceSet OriginalTotalDutiesSet { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used used to display prices to the customer.
        /// </summary>
        [JsonProperty("presentment_currency")]
        public string PresentmentCurrency { get; set; }
 
        /// <summary>
        /// The total of all line item prices in shop and presentment currencies.
        /// </summary>
        [JsonProperty("total_line_items_price_set")]
        public PriceSet TotalLineItemsPriceSet { get; set; }
 
        /// <summary>
        /// The total discounts applied to the price of the order in shop and presentment currencies.
        /// </summary>        
        [JsonProperty("total_discounts_set")]
        public PriceSet TotalDiscountsSet { get; set; }
 
        /// <summary>
        /// The total shipping price of the order, excluding discounts and returns, in shop and presentment currencies.
        /// If taxes_included is set to true, then total_shipping_price_set includes taxes.
        /// </summary>
        [JsonProperty("total_shipping_price_set")]
        public PriceSet TotalShippingPriceSet { get; set; }
 
        /// <summary>
        /// The subtotal of the order in shop and presentment currencies.
        /// </summary>
        [JsonProperty("subtotal_price_set")]
        public PriceSet SubtotalPriceSet { get; set; }

        /// <summary>
        /// The total price of the order in shop and presentment currencies.
        /// </summary>
        [JsonProperty("total_price_set")]
        public PriceSet TotalPriceSet { get; set; }

        /// <summary>
        /// The total tax applied to the order in shop and presentment currencies.
        /// </summary>
        [JsonProperty("total_tax_set")]
        public PriceSet TotalTaxSet { get; set; }
    }
}
