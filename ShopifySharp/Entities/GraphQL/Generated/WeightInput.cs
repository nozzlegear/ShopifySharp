#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the weight unit and value inputs.
/// </summary>
public record WeightInput : GraphQLInputObject<WeightInput>
{
    /// <summary>
    /// Unit of measurement for `value`.
    /// </summary>
    [JsonPropertyName("unit")]
    public WeightUnit? unit { get; set; } = null;

    /// <summary>
    /// The weight value using the unit system specified with `weight_unit`.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;
}