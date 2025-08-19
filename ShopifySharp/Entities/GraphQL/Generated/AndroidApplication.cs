#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Android mobile platform application.
/// </summary>
public record AndroidApplication : MobilePlatformApplication, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The Android application ID.
    /// </summary>
    [JsonPropertyName("applicationId")]
    public string? applicationId { get; set; } = null;

    /// <summary>
    /// Whether Android App Links are supported by this app.
    /// </summary>
    [JsonPropertyName("appLinksEnabled")]
    public bool? appLinksEnabled { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The SHA256 fingerprints of the app's signing certificate.
    /// </summary>
    [JsonPropertyName("sha256CertFingerprints")]
    public ICollection<string>? sha256CertFingerprints { get; set; } = null;
}