#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to determine which discount classes the discount can combine with.
/// </summary>
public record DiscountCombinesWithInput : GraphQLInputObject<DiscountCombinesWithInput>
{
    /// <summary>
    /// Whether the discount combines with the
    /// [order discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("orderDiscounts")]
    public bool? orderDiscounts { get; set; } = null;

    /// <summary>
    /// Whether the discount combines with the
    /// [product discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("productDiscounts")]
    public bool? productDiscounts { get; set; } = null;

    /// <summary>
    /// Controls which product discounts can apply together on the same cart line. By
    /// default, only one product discount applies per line. Available only on a Shopify
    /// Plus plan and requires the `productDiscounts` field to be set to `true`.
    /// For discounts to apply together, they must match tags in both directions. Each
    /// discount has two tag sets: the tags it's tagged with, and the tags it agrees to
    /// apply with (this field). Two discounts apply together only if each one allows at
    /// least one tag that the other is tagged with. Any number of product discounts can
    /// apply to the same line if this two-way match holds for every pair in the group.
    /// Example: Discount A is tagged with "LOYALTY" and allows "SEASONAL," and Discount B
    /// is tagged with "SEASONAL" and allows "LOYALTY." They apply together. To add a
    /// third discount, it must meet the same mutual-match rule with both A and B.
    /// </summary>
    [JsonPropertyName("productDiscountsWithTagsOnSameCartLine")]
    public ProductDiscountsWithTagsOnSameCartLineInput? productDiscountsWithTagsOnSameCartLine { get; set; } = null;

    /// <summary>
    /// Whether the discount combines
    /// with the
    /// [shipping discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("shippingDiscounts")]
    public bool? shippingDiscounts { get; set; } = null;
}