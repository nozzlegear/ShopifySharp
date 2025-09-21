#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an applied discount on a calculated exchange line item.
/// </summary>
public record ExchangeLineItemAppliedDiscountInput : GraphQLInputObject<ExchangeLineItemAppliedDiscountInput>
{
    /// <summary>
    /// The description of the discount.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The value of the discount as a fixed amount or a percentage.
    /// </summary>
    [JsonPropertyName("value")]
    public ExchangeLineItemAppliedDiscountValueInput? @value { get; set; } = null;
}