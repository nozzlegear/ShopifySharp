using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class DraftOrder : ShopifyObject
    {
        /// <summary>
        /// The unique numeric identifier for the order associated to the draft order, once created.
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// Name of the draft order.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Customer associated with the draft order. Customer associated with the draft order. Used to load/remove the associated customer with customer id. When a customer is loaded, the customer’s email address is also assocaited.
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// The mailing address associated with the payment method. This address is an optional field that will not be available on orders that do not require one. 
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The text of an optional note that a shop owner can attach to the draft order.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Extra information that is added to the order.
        /// </summary>
        [JsonProperty("note_attributes")]
        public IEnumerable<NoteAttribute> NoteAttributes { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// This auto-generated property is the date and time when the invoice was emailed to the customer, in ISO 8601 format. 
        /// </summary>
        [JsonProperty("invoice_sent_at")]
        public DateTimeOffset? InvoiceSentAt { get; set; }

        /// <summary>
        /// The URL for the invoice.
        /// </summary>
        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// Product variant line item or custom line item associated to the draft order. Each draft order must include at least one line_item.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<DraftLineItem> LineItems { get; set; }

        /// <summary>
        /// Details the shipping method used.
        /// </summary>
        [JsonProperty("shipping_line")]
        public DraftShippingLine ShippingLine { get; set; }

        /// <summary>
        /// Tags are additional short descriptors, commonly used for filtering and searching, formatted as a string of comma-separated values.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Sets whether or not taxes are exempt for the draft order. If this field is set to false, then Shopify will refer to the taxable field for each line_item. If a customer is applied to the draft order, then Shopify will use the customer's tax_exempt field instead. 
        /// </summary>
        [JsonProperty("tax_exempt")]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Whether the customer is exempt from paying specific taxes on their order
        /// </summary>
        [JsonProperty("tax_exemptions")]
        public IEnumerable<string> TaxExemptions { get; set; }

        /// <summary>
        /// An array of tax_line objects, each of which details the total taxes applicable to the order. When creating an order through the API, tax lines may be specified on the order or the line items but not both. Tax lines specified on the order are split on the taxable line items in the created order. 
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Discount which will be applied to the line item or the overall order. A draft order line_item can have one discount. A draft order can have one order-level discount.
        /// </summary>
        [JsonProperty("applied_discount")]
        public AppliedDiscount AppliedDiscount { get; set; }

        /// <summary>
        /// States whether or not taxes are included in the order subtotal. 
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool? TaxesIncluded { get; set; }

        /// <summary>
        /// The sum of all the taxes applied to the order (must be positive). 
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Price of the order before shipping and taxes
        /// </summary>
        [JsonProperty("subtotal_price")]
        public decimal? SubtotalPrice { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order, taxes and discounts included (must be positive).
        /// </summary>
        [JsonProperty("total_price")]
        public decimal? TotalPrice { get; set; }

        /// <summary>
        /// Date at which order is created and the draft order changes to completed status. The API returns this value in ISO 8601 format. 
        /// </summary>
        [JsonProperty("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// This auto-generated property is the date and time when the draft order was created in Shopify, in ISO 8601 format. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the order was last modified. The API returns this value in ISO 8601 format. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Once a draft order is set to status completed the only further draft order modifications that can be made are adding tags or metafields. No other draft order actions are permitted.
        /// Known values are "open", "invoice_sent", and "completed".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional metadata about the <see cref="DraftOrder"/>. Note: This is not naturally returned with a <see cref="DraftOrder"/> response, as
        /// Shopify will not return <see cref="DraftOrder"/> metafields unless specified. Instead, you need to query metafields with <see cref="MetaFieldService"/>. 
        /// Uses include: Creating, updating, & deserializing webhook bodies that include them.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<MetaField> Metafields { get; set; }

        /// <summary>
        /// An optional boolean that you can send as part of a draft order object to load customer shipping information.
        /// </summary>
        [JsonProperty("use_customer_default_address")]
        public bool? UseCustomerDefaultAddress { get; set; }

        /// <summary>
        /// The terms and conditions under which a payment should be processed.
        /// </summary>
        [JsonProperty("payment_terms")]
        public PaymentTerms PaymentTerms { get; set; }
    }
}
