#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A custom font.
/// </summary>
public record CheckoutBrandingCustomFont : IGraphQLObject, ICheckoutBrandingFont
{
    /// <summary>
    /// Globally unique ID reference to the custom font file.
    /// </summary>
    [JsonPropertyName("genericFileId")]
    public string? genericFileId { get; set; } = null;

    /// <summary>
    /// The font sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public string? sources { get; set; } = null;

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; } = null;
}