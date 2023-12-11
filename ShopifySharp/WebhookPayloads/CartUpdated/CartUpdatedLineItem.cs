using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.WebhookPayloads.CartUpdated
{
    public class CartUpdatedLineItem : ShopifyObject
    {
        #nullable enable
        [JsonProperty("properties")]
        public IDictionary<string, object>? Properties { get; set; }
        #nullable disable

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("variant_id")]
        public long VariantId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("discounted_price")]
        public decimal DiscountedPrice { get; set; }

        [JsonProperty("gift_card")]
        public bool? GiftCard { get; set; }

        [JsonProperty("grams")]
        public int? Grams { get; set; }

        [JsonProperty("line_price")]
        public decimal LinePrice { get; set; }

        [JsonProperty("original_line_price")]
        public decimal OriginalLinePrice { get; set; }

        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        #nullable enable
        [JsonProperty("sku")]
        public string? Sku { get; set; }
        #nullable disable

        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_discount")]
        public decimal TotalDiscount { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("discounted_price_set")]
        public CartUpdatedDiscountedPriceSet DiscountedPriceSet { get; set; }

        [JsonProperty("line_price_set")]
        public CartUpdatedLinePriceSet LinePriceSet { get; set; }

        [JsonProperty("original_line_price_set")]
        public CartUpdatedOriginalLinePriceSet OriginalLinePriceSet { get; set; }

        [JsonProperty("price_set")]
        public CartUpdatedPriceSet PriceSet { get; set; }

        [JsonProperty("total_discount_set")]
        public CartUpdatedTotalDiscountSet TotalDiscountSet { get; set; }

        [JsonProperty("discounts")]
        public ICollection<object> Discounts { get; set; }
    }
}
