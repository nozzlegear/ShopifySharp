using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CheckoutSalesChannel
    {
        [JsonProperty("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("presentment_currency")]
        public string PresentmentCurrency { get; set; }

        [JsonProperty("customer_id")]
        public long? CustomerId { get; set; }

        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("discount_code")]
        public string DiscountCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("legal_notice_url")]
        public Uri LegalNoticeUrl { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("note_attributes")]
        public Dictionary<string, string> NoteAttributes { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_status_url")]
        public Uri OrderStatusUrl { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }

        [JsonProperty("payment_due")]
        public string PaymentDue { get; set; }

        [JsonProperty("payment_url")]
        public Uri PaymentUrl { get; set; }

        [JsonProperty("payments")]
        public PaymentSalesChannel[] Payments { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("shopify_payments_account_id")]
        public string ShopifyPaymentsAccountId { get; set; }

        [JsonProperty("privacy_policy_url")]
        public Uri PrivacyPolicyUrl { get; set; }

        [JsonProperty("refund_policy_url")]
        public Uri RefundPolicyUrl { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("reservation_time_left")]
        public long ReservationTimeLeft { get; set; }

        /// <summary>
        /// The reservation time in seconds for the line item products. Default value: null. This property is not writable.
        /// </summary>
        [JsonProperty("reservation_time")]
        [Obsolete]
        public long? ReservationTime { get; set; }

        [JsonProperty("source_identifier")]
        public string SourceIdentifier { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("source_url")]
        public Uri SourceUrl { get; set; }

        [JsonProperty("subscription_policy_url")]
        public Uri SubscriptionPolicyUrl { get; set; }

        [JsonProperty("subtotal_price")]
        public string SubtotalPrice { get; set; }

        [JsonProperty("shipping_policy_url")]
        public Uri ShippingPolicyUrl { get; set; }

        [JsonProperty("tax_exempt")]
        public bool TaxExempt { get; set; }

        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }

        [JsonProperty("terms_of_sale_url")]
        public Uri TermsOfSaleUrl { get; set; }

        [JsonProperty("terms_of_service_url")]
        public Uri TermsOfServiceUrl { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("total_price")]
        public string TotalPrice { get; set; }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        [JsonProperty("total_tip_received")]
        public string TotalTipReceived { get; set; }

        [JsonProperty("total_line_items_price")]
        public string TotalLineItemsPrice { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("web_url")]
        public Uri WebUrl { get; set; }

        [JsonProperty("line_items")]
        public IEnumerable<CheckoutSalesChannelLineItem> LineItems { get; set; }

        [JsonProperty("gift_cards")]
        public IEnumerable<GiftCard> GiftCards { get; set; }

        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        //[JsonProperty("tax_manipulations")]
        //public object[] TaxManipulations { get; set; }

        [JsonProperty("shipping_line")]
        public CheckoutShippingRate ShippingLine { get; set; }

        [JsonProperty("shipping_rate")]
        public CheckoutShippingRate ShippingRate { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonProperty("credit_card")]
        public CreditCard CreditCard { get; set; }

        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        [JsonProperty("applied_discount")]
        public AppliedDiscount AppliedDiscount { get; set; }
    }
}
