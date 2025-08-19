#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create a Subscription Contract.
/// </summary>
public record SubscriptionContractProductChangeInput : GraphQLInputObject<SubscriptionContractProductChangeInput>
{
    /// <summary>
    /// The price of the product.
    /// </summary>
    [JsonPropertyName("currentPrice")]
    public decimal? currentPrice { get; set; } = null;

    /// <summary>
    /// The ID of the product variant the subscription line refers to.
    /// </summary>
    [JsonPropertyName("productVariantId")]
    public string? productVariantId { get; set; } = null;
}