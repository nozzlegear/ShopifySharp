#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to detach media from a single variant.
/// </summary>
public record ProductVariantDetachMediaInput : GraphQLInputObject<ProductVariantDetachMediaInput>
{
    /// <summary>
    /// Specifies the media to detach from the variant.
    /// </summary>
    [JsonPropertyName("mediaIds")]
    public ICollection<string>? mediaIds { get; set; } = null;

    /// <summary>
    /// Specifies the variant from which media will be detached.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}