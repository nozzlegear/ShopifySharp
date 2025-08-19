#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The suggested values for a refund to store credit.
/// </summary>
public record SuggestedStoreCreditRefund : IGraphQLObject, ISuggestedRefundMethod
{
    /// <summary>
    /// The suggested amount to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; } = null;

    /// <summary>
    /// The suggested expiration date for the store credit.
    /// </summary>
    [JsonPropertyName("expiresAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? expiresAt { get; set; } = null;

    /// <summary>
    /// The maximum available amount to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    public MoneyBag? maximumRefundable { get; set; } = null;
}