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
/// A weight measurement with its numeric value and unit. Used throughout the API,
/// for example in shipping calculations, delivery conditions, order line items, and
/// inventory measurements.
/// The weight combines a decimal value with a standard unit of measurement to
/// ensure consistent weight handling across different regional systems.
/// </summary>
public record Weight : IGraphQLUnionCase, IGraphQLObject
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