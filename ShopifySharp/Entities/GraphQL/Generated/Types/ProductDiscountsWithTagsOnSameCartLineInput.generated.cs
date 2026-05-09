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
/// Controls which product discounts can apply together on the same cart line. By
/// default, only one product discount applies per line. Available only on a Shopify
/// Plus plan.
/// For discounts to apply together, they must match tags in both directions. Each
/// discount has two tag sets: the tags it is tagged with, and the tags it agrees to
/// apply with (this field). Two discounts apply together only if each one allows at
/// least one tag that the other is tagged with. Any number of product discounts can
/// apply to the same line if this two-way match holds for every pair in the group.
/// Example: Discount A is tagged with "LOYALTY" and allows "SEASONAL," and Discount B
/// is tagged with "SEASONAL" and allows "LOYALTY." They apply together. To add a
/// third discount, it must meet the same mutual-match rule with both A and B.
/// </summary>
public record ProductDiscountsWithTagsOnSameCartLineInput : GraphQLInputObject<ProductDiscountsWithTagsOnSameCartLineInput>
{
    /// <summary>
    /// The tags to add to this discount's combination list. When this discount and
    /// another product discount share a matching tag, both discounts can apply to
    /// the same cart line. For example, adding the tag "SEASONAL" allows this
    /// discount to combine with any other product discount that also has the
    /// "SEASONAL" tag on the same cart line.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// The tags to remove from this discount's combination list. When you remove a
    /// tag, this discount will no longer combine with product discounts that only
    /// have the removed tag. If this discount and another product discount share
    /// additional tags after the removal, both discounts can still apply to the
    /// same cart line.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}