#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to add a discount during an order edit.
/// </summary>
public record OrderEditAppliedDiscountInput : GraphQLInputObject<OrderEditAppliedDiscountInput>
{
    /// <summary>
    /// The description of the discount.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The value of the discount as a fixed amount.
    /// </summary>
    [JsonPropertyName("fixedValue")]
    public MoneyInput? fixedValue { get; set; } = null;

    /// <summary>
    /// The value of the discount as a percentage.
    /// </summary>
    [JsonPropertyName("percentValue")]
    public decimal? percentValue { get; set; } = null;
}