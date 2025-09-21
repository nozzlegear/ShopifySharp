#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Bounding box information of a 3d model.
/// </summary>
public record Model3dBoundingBox : IGraphQLObject
{
    /// <summary>
    /// Size in meters of the smallest volume which contains the 3d model.
    /// </summary>
    [JsonPropertyName("size")]
    public Vector3? size { get; set; } = null;
}