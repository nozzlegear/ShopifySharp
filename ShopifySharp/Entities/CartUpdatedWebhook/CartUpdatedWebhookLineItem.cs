using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.CartUpdatedWebhook
{
    public class CartUpdatedWebhookLineItem : ShopifyObject
    {
        [JsonProperty("properties")]
        public IDictionary<string, object> Properties { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("variant_id")]
        public long? VariantId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("discounted_price")]
        public string DiscountedPrice { get; set; }

        [JsonProperty("gift_card")]
        public bool? GiftCard { get; set; }

        [JsonProperty("grams")]
        public int? Grams { get; set; }

        [JsonProperty("line_price")]
        public string LinePrice { get; set; }

        [JsonProperty("original_line_price")]
        public string OriginalLinePrice { get; set; }

        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_discount")]
        public string TotalDiscount { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("discounted_price_set")]
        public CartUpdatedWebhookDiscountedPriceSet DiscountedPriceSet { get; set; }

        [JsonProperty("line_price_set")]
        public CartUpdatedWebhookLinePriceSet LinePriceSet { get; set; }

        [JsonProperty("original_line_price_set")]
        public CartUpdatedWebhookOriginalLinePriceSet OriginalLinePriceSet { get; set; }

        [JsonProperty("price_set")]
        public CartUpdatedWebhookPriceSet PriceSet { get; set; }

        [JsonProperty("total_discount_set")]
        public CartUpdatedWebhookTotalDiscountSet TotalDiscountSet { get; set; }

        [JsonProperty("discounts")]
        public IEnumerable<object> Discounts { get; set; }
    }
}
