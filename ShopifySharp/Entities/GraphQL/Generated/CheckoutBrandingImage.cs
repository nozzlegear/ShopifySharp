#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A checkout branding image.
/// </summary>
public record CheckoutBrandingImage : IGraphQLObject
{
    /// <summary>
    /// The image details.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;
}