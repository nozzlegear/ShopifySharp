#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Generic attributes of a suggested refund method.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SuggestedStoreCreditRefund), typeDiscriminator: "SuggestedStoreCreditRefund")]
public interface ISuggestedRefundMethod : IGraphQLObject
{
    /// <summary>
    /// The suggested amount to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; }

    /// <summary>
    /// The maximum available amount to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    public MoneyBag? maximumRefundable { get; set; }
}