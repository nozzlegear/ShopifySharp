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
/// discount has two tag sets: the tags that identify the discount, and the tags that
/// it agrees to apply with. Use the `tags` field on the discount input to set the
/// discount's own tags. Use this input object to set the tags that the discount can
/// apply with. Two discounts apply together only if each one allows at least one tag
/// that the other is tagged with. Any number of product discounts can apply to the
/// same line if this two-way match holds for every pair in the group.
/// Example: Discount A is tagged with `LOYALTY` and allows `SEASONAL`, and Discount B
/// is tagged with `SEASONAL` and allows `LOYALTY`. They apply together. To add a
/// third discount, it must meet the same mutual-match rule with both A and B.
/// </summary>
public record ProductDiscountsWithTagsOnSameCartLineInput : GraphQLInputObject<ProductDiscountsWithTagsOnSameCartLineInput>
{
    /// <summary>
    /// The tags to add to this discount's combination list. This field doesn't add
    /// tags to the discount itself. To change the tags on the discount, use the
    /// discount input's `tags` field or the
    /// [`tagsAdd`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// and [`tagsRemove`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsremove)
    /// mutations.
    /// If another product discount has a matching tag and also allows at least one
    /// tag on this discount, then both discounts can apply to the same cart line.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// The tags to remove from this discount's combination list. This field doesn't
    /// remove tags from the discount itself. To change the tags on the discount, use
    /// the discount input's `tags` field or the
    /// [`tagsAdd`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// and [`tagsRemove`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsremove)
    /// mutations.
    /// If this discount and another product discount still match tags in both
    /// directions after the removal, then both discounts can still apply to the same
    /// cart line.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}