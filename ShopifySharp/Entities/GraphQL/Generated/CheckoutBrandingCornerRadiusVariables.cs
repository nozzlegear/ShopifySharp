#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Define the pixel size of corner radius options.
/// </summary>
public record CheckoutBrandingCornerRadiusVariables : IGraphQLObject
{
    /// <summary>
    /// The value in pixels for base corner radii. Example: 5.
    /// </summary>
    [JsonPropertyName("base")]
    public int? @base { get; set; } = null;

    /// <summary>
    /// The value in pixels for large corner radii. Example: 10.
    /// </summary>
    [JsonPropertyName("large")]
    public int? large { get; set; } = null;

    /// <summary>
    /// The value in pixels for small corner radii. Example: 3.
    /// </summary>
    [JsonPropertyName("small")]
    public int? small { get; set; } = null;
}