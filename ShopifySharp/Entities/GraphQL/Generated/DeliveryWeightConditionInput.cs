#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a weight-based condition of a delivery method definition.
/// </summary>
public record DeliveryWeightConditionInput : GraphQLInputObject<DeliveryWeightConditionInput>
{
    /// <summary>
    /// The weight value to compare the weight of an order to.
    /// </summary>
    [JsonPropertyName("criteria")]
    public WeightInput? criteria { get; set; } = null;

    /// <summary>
    /// The operator to use for comparison.
    /// </summary>
    [JsonPropertyName("operator")]
    public DeliveryConditionOperator? @operator { get; set; } = null;
}