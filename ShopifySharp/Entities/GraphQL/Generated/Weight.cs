#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A weight, which includes a numeric value and a unit of measurement.
/// </summary>
public record Weight : DeliveryConditionCriteria, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The unit of measurement for `value`.
    /// </summary>
    [JsonPropertyName("unit")]
    public WeightUnit? unit { get; set; } = null;

    /// <summary>
    /// The weight value using the unit system specified with `unit`.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;
}