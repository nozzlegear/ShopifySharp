#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The App Bridge information for a Shopify Function.
/// </summary>
public record FunctionsAppBridge : IGraphQLObject
{
    /// <summary>
    /// The relative path for creating a customization.
    /// </summary>
    [JsonPropertyName("createPath")]
    public string? createPath { get; set; } = null;

    /// <summary>
    /// The relative path for viewing a customization.
    /// </summary>
    [JsonPropertyName("detailsPath")]
    public string? detailsPath { get; set; } = null;
}