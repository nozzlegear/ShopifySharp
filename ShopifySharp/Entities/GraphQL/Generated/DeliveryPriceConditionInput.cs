#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a price-based condition of a delivery method definition.
/// </summary>
public record DeliveryPriceConditionInput : GraphQLInputObject<DeliveryPriceConditionInput>
{
    /// <summary>
    /// The monetary value to compare the price of an order to.
    /// </summary>
    [JsonPropertyName("criteria")]
    public MoneyInput? criteria { get; set; } = null;

    /// <summary>
    /// The operator to use for comparison.
    /// </summary>
    [JsonPropertyName("operator")]
    public DeliveryConditionOperator? @operator { get; set; } = null;
}