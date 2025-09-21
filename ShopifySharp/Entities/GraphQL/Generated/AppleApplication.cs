#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The Apple mobile platform application.
/// </summary>
public record AppleApplication : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The iOS App Clip application ID.
    /// </summary>
    [JsonPropertyName("appClipApplicationId")]
    public string? appClipApplicationId { get; set; } = null;

    /// <summary>
    /// Whether iOS App Clips are enabled for this app.
    /// </summary>
    [JsonPropertyName("appClipsEnabled")]
    public bool? appClipsEnabled { get; set; } = null;

    /// <summary>
    /// The iOS App ID.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? appId { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether iOS shared web credentials are enabled for this app.
    /// </summary>
    [JsonPropertyName("sharedWebCredentialsEnabled")]
    public bool? sharedWebCredentialsEnabled { get; set; } = null;

    /// <summary>
    /// Whether iOS Universal Links are supported by this app.
    /// </summary>
    [JsonPropertyName("universalLinksEnabled")]
    public bool? universalLinksEnabled { get; set; } = null;
}