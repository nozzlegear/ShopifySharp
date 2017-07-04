using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify Abandoned Checkout
    /// </summary>
    public class ShopifyAbandonedCheckout : ShopifyObject
    {
        /// <summary>
        /// Gets or sets the abandoned checkout URL.
        /// </summary>
        /// <value>
        /// The abandoned checkout URL.
        /// </value>
        [JsonProperty("abandoned_checkout_url")]
        public string AbandonedCheckoutUrl { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        /// <value>
        /// The billing address.
        /// </value>
        [JsonProperty("billing_address")]
        public ShopifyAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [buyer accepts marketing].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [buyer accepts marketing]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }

        /// <summary>
        /// Gets or sets the cancel reason.
        /// </summary>
        /// <value>
        /// The cancel reason.
        /// </value>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// Gets or sets the cart token.
        /// </summary>
        /// <value>
        /// The cart token.
        /// </value>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        /// <summary>
        /// Gets or sets the closed at.
        /// </summary>
        /// <value>
        /// The closed at.
        /// </value>
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Gets or sets the completed at.
        /// </summary>
        /// <value>
        /// The completed at.
        /// </value>
        [JsonProperty("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        [JsonProperty("customer")]
        public ShopifyCustomer Customer { get; set; }

        /// <summary>
        /// Gets or sets the discount codes.
        /// </summary>
        /// <value>
        /// The discount codes.
        /// </value>
        [JsonProperty("discount_codes")]
        public IEnumerable<ShopifyDiscountCode> DiscountCodes { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the gateway.
        /// </summary>
        /// <value>
        /// The gateway.
        /// </value>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

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
        public new long Id { get; set; }

        /// <summary>
        /// Gets or sets the landing site.
        /// </summary>
        /// <value>
        /// The landing site.
        /// </value>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        /// <summary>
        /// A historical record of each item in the fulfillment.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<ShopifyAbandonedCheckoutLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>
        /// The note.
        /// </value>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the referring site.
        /// </summary>
        /// <value>
        /// The referring site.
        /// </value>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        /// <value>
        /// The shipping address.
        /// </value>
        [JsonProperty("shipping_address")]
        public ShopifyAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the shipping lines.
        /// </summary>
        /// <value>
        /// The shipping lines.
        /// </value>
        [JsonProperty("shipping_lines")]
        public IEnumerable<ShopifyShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        /// <value>
        /// The name of the source.
        /// </value>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or sets the sub total price.
        /// </summary>
        /// <value>
        /// The sub total price.
        /// </value>
        [JsonProperty("subtotal_price")]
        public decimal SubTotalPrice { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyTaxLine"/> objects, each of which details the total taxes applicable to the order.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<ShopifyTaxLine> TaxLines { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [taxes included].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [taxes included]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the total discounts.
        /// </summary>
        /// <value>
        /// The total discounts.
        /// </value>
        [JsonProperty("total_discounts")]
        public decimal TotalDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the total line items price.
        /// </summary>
        /// <value>
        /// The total line items price.
        /// </value>
        [JsonProperty("total_line_items_price")]
        public decimal TotalLineItemsPrice { get; set; }

        /// <summary>
        /// Gets or sets the total price.
        /// </summary>
        /// <value>
        /// The total price.
        /// </value>
        [JsonProperty("total_price")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets the total weight.
        /// </summary>
        /// <value>
        /// The total weight.
        /// </value>
        [JsonProperty("total_weight")]
        public decimal TotalWeight { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>
        /// The updated at.
        /// </value>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
