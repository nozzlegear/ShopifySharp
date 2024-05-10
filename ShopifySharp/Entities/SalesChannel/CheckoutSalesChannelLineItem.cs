using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel;

public class CheckoutSalesChannelLineItem
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
    public decimal? CompareAtPrice { get; set; }

    [JsonProperty("line_price")]
    public string LinePrice { get; set; }

    [JsonProperty("properties")]
    public Dictionary<string, string> Properties { get; set; }

    [JsonProperty("quantity")]
    public long Quantity { get; set; }

    [JsonProperty("grams")]
    public long? Grams { get; set; }

    [JsonProperty("fulfillment_service")]
    public string FulfillmentService { get; set; }

    [JsonProperty("applied_discounts")]
    public IEnumerable<AppliedDiscount> AppliedDiscounts { get; set; }

    [JsonProperty("discount_allocations")]
    public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

    [JsonProperty("tax_lines")]
    public IEnumerable<TaxLine> TaxLines { get; set; }
}