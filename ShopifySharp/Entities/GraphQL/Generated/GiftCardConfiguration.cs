#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents information about the configuration of gift cards on the shop.
/// </summary>
public record GiftCardConfiguration : IGraphQLObject
{
    /// <summary>
    /// The issue limit for gift cards in the default shop currency.
    /// </summary>
    [JsonPropertyName("issueLimit")]
    public MoneyV2? issueLimit { get; set; } = null;

    /// <summary>
    /// The purchase limit for gift cards in the default shop currency.
    /// </summary>
    [JsonPropertyName("purchaseLimit")]
    public MoneyV2? purchaseLimit { get; set; } = null;
}