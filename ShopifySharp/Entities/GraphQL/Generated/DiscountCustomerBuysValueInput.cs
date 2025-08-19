#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountCustomerBuysValueDiscountPurchaseAmount(DiscountPurchaseAmount Value): DiscountCustomerBuysValue;
internal record DiscountCustomerBuysValueDiscountQuantity(DiscountQuantity Value): DiscountCustomerBuysValue;
#endif /// <summary>

/// The input fields for prerequisite quantity or minimum purchase amount required for the discount.
/// </summary>
public record DiscountCustomerBuysValueInput : GraphQLInputObject<DiscountCustomerBuysValueInput>
{
    /// <summary>
    /// The prerequisite minimum purchase amount required for the discount to be applicable.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The quantity of prerequisite items.
    /// </summary>
    [JsonPropertyName("quantity")]
    public ulong? quantity { get; set; } = null;
}