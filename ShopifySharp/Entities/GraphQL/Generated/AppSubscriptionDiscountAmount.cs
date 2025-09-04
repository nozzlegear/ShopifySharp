#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fixed amount value of a discount.
/// </summary>
public record AppSubscriptionDiscountAmount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The fixed amount value of a discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;
}