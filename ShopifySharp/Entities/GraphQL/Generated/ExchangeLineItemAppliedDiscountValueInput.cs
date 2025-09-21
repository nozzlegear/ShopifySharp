#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input value for an applied discount on a calculated exchange line item.
/// Can either specify the value as a fixed amount or a percentage.
/// </summary>
public record ExchangeLineItemAppliedDiscountValueInput : GraphQLInputObject<ExchangeLineItemAppliedDiscountValueInput>
{
    /// <summary>
    /// The value of the discount as a fixed amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyInput? amount { get; set; } = null;

    /// <summary>
    /// The value of the discount as a percentage.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}