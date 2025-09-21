#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a font.
/// </summary>
public record CheckoutBrandingCustomFontInput : GraphQLInputObject<CheckoutBrandingCustomFontInput>
{
    /// <summary>
    /// A globally-unique ID for a font file uploaded via the Files api.
    /// Allowed font types are .woff and .woff2.
    /// </summary>
    [JsonPropertyName("genericFileId")]
    public string? genericFileId { get; set; } = null;

    /// <summary>
    /// The font weight. Its value should be between 100 and 900.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; } = null;
}