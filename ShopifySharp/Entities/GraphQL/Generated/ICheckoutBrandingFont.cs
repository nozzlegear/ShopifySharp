#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A font.
/// </summary>
public interface ICheckoutBrandingFont : IGraphQLObject
{
    /// <summary>
    /// The font sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public string? sources { get; set; }

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; }
}