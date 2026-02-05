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