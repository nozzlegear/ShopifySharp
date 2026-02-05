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
    public DateTimeOffset? expiresAt { get; set; } = null;

    /// <summary>
    /// The maximum available amount to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    public MoneyBag? maximumRefundable { get; set; } = null;
}