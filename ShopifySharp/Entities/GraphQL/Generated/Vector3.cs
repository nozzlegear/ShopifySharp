#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Representation of 3d vectors and points. It can represent
/// either the coordinates of a point in space, a direction, or
/// size. Presented as an object with three floating-point values.
/// </summary>
public record Vector3 : IGraphQLObject
{
    /// <summary>
    /// The x coordinate of Vector3.
    /// </summary>
    [JsonPropertyName("x")]
    public decimal? x { get; set; } = null;

    /// <summary>
    /// The y coordinate of Vector3.
    /// </summary>
    [JsonPropertyName("y")]
    public decimal? y { get; set; } = null;

    /// <summary>
    /// The z coordinate of Vector3.
    /// </summary>
    [JsonPropertyName("z")]
    public decimal? z { get; set; } = null;
}