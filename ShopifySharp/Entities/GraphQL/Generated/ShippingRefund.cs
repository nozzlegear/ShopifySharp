#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the shipping costs refunded on the Refund.
/// </summary>
public record ShippingRefund : IGraphQLObject
{
    /// <summary>
    /// The monetary value of the shipping fees to be refunded.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `amountSet` instead.")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The monetary value of the shipping fees to be refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The maximum amount of shipping fees currently refundable.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    [Obsolete("Use `maximumRefundableSet` instead.")]
    public decimal? maximumRefundable { get; set; } = null;

    /// <summary>
    /// The maximum amount of shipping fees currently refundable in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundableSet")]
    public MoneyBag? maximumRefundableSet { get; set; } = null;

    /// <summary>
    /// The monetary value of the tax allocated to shipping fees to be refunded.
    /// </summary>
    [JsonPropertyName("tax")]
    [Obsolete("Use `taxSet` instead.")]
    public decimal? tax { get; set; } = null;

    /// <summary>
    /// The monetary value of the tax allocated to shipping fees to be refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("taxSet")]
    public MoneyBag? taxSet { get; set; } = null;
}