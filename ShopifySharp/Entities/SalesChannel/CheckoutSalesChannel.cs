using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class CheckoutSalesChannel
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
        public object DeviceId { get; set; }

        [JsonProperty("discount_code")]
        public object DiscountCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("legal_notice_url")]
        public Uri LegalNoticeUrl { get; set; }

        [JsonProperty("location_id")]
        public object LocationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("note_attributes")]
        public NoteAttributes NoteAttributes { get; set; }

        [JsonProperty("order_id")]
        public object OrderId { get; set; }

        [JsonProperty("order_status_url")]
        public object OrderStatusUrl { get; set; }

        [JsonProperty("order")]
        public object Order { get; set; }

        [JsonProperty("payment_due")]
        public string PaymentDue { get; set; }

        [JsonProperty("payment_url")]
        public Uri PaymentUrl { get; set; }

        [JsonProperty("payments")]
        public object[] Payments { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("shopify_payments_account_id")]
        public object ShopifyPaymentsAccountId { get; set; }

        [JsonProperty("privacy_policy_url")]
        public Uri PrivacyPolicyUrl { get; set; }

        [JsonProperty("refund_policy_url")]
        public Uri RefundPolicyUrl { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("reservation_time_left")]
        public long ReservationTimeLeft { get; set; }

        [JsonProperty("reservation_time")]
        public object ReservationTime { get; set; }

        [JsonProperty("source_identifier")]
        public object SourceIdentifier { get; set; }

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
        public object UserId { get; set; }

        [JsonProperty("web_url")]
        public Uri WebUrl { get; set; }

        [JsonProperty("line_items")]
        public IEnumerable<CheckoutSalesChannelLineItem> LineItems { get; set; }

        [JsonProperty("gift_cards")]
        public object[] GiftCards { get; set; }

        [JsonProperty("tax_lines")]
        public object[] TaxLines { get; set; }

        [JsonProperty("tax_manipulations")]
        public object[] TaxManipulations { get; set; }

        [JsonProperty("shipping_line")]
        public CheckoutShippingRate ShippingLine { get; set; }

        [JsonProperty("shipping_rate")]
        public CheckoutShippingRate ShippingRate { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonProperty("credit_card")]
        public object CreditCard { get; set; }

        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        [JsonProperty("applied_discount")]
        public object AppliedDiscount { get; set; }
    }

    public partial class CheckoutSalesChannelLineItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("variant_id")]
        public long VariantId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("gift_card")]
        public bool GiftCard { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("compare_at_price")]
        public object CompareAtPrice { get; set; }

        [JsonProperty("line_price")]
        public string LinePrice { get; set; }

        [JsonProperty("properties")]
        public NoteAttributes Properties { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("grams")]
        public long? Grams { get; set; }

        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

        [JsonProperty("applied_discounts")]
        public object[] AppliedDiscounts { get; set; }

        [JsonProperty("discount_allocations")]
        public object[] DiscountAllocations { get; set; }

        [JsonProperty("tax_lines")]
        public object[] TaxLines { get; set; }
    }

    public partial class NoteAttributes
    {
    }
}
