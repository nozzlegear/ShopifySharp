#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an Android based mobile platform application.
/// </summary>
public record MobilePlatformApplicationUpdateAndroidInput : GraphQLInputObject<MobilePlatformApplicationUpdateAndroidInput>
{
    /// <summary>
    /// Android application ID.
    /// </summary>
    [JsonPropertyName("applicationId")]
    public string? applicationId { get; set; } = null;

    /// <summary>
    /// Whether Android App Links are supported by this app.
    /// </summary>
    [JsonPropertyName("appLinksEnabled")]
    public bool? appLinksEnabled { get; set; } = null;

    /// <summary>
    /// The SHA256 fingerprints of the app’s signing certificate.
    /// </summary>
    [JsonPropertyName("sha256CertFingerprints")]
    public ICollection<string>? sha256CertFingerprints { get; set; } = null;
}