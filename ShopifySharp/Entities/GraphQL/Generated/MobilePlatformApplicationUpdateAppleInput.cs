#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an Apple based mobile platform application.
/// </summary>
public record MobilePlatformApplicationUpdateAppleInput : GraphQLInputObject<MobilePlatformApplicationUpdateAppleInput>
{
    /// <summary>
    /// The Apple App Clip application ID.
    /// </summary>
    [JsonPropertyName("appClipApplicationId")]
    public string? appClipApplicationId { get; set; } = null;

    /// <summary>
    /// Whether Apple App Clips are enabled for this app.
    /// </summary>
    [JsonPropertyName("appClipsEnabled")]
    public bool? appClipsEnabled { get; set; } = null;

    /// <summary>
    /// Apple application ID.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? appId { get; set; } = null;

    /// <summary>
    /// Whether Apple shared web credentials are enabled for this app.
    /// </summary>
    [JsonPropertyName("sharedWebCredentialsEnabled")]
    public bool? sharedWebCredentialsEnabled { get; set; } = null;

    /// <summary>
    /// Whether Apple Universal Links are supported by this app.
    /// </summary>
    [JsonPropertyName("universalLinksEnabled")]
    public bool? universalLinksEnabled { get; set; } = null;
}