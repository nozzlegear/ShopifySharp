#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to append media to a single variant.
/// </summary>
public record ProductVariantAppendMediaInput : GraphQLInputObject<ProductVariantAppendMediaInput>
{
    /// <summary>
    /// Specifies the media to append to the variant.
    /// </summary>
    [JsonPropertyName("mediaIds")]
    public ICollection<string>? mediaIds { get; set; } = null;

    /// <summary>
    /// Specifies the variant to which media will be appended.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}