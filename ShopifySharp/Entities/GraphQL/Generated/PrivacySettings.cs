#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shop's privacy settings.
/// </summary>
public record PrivacySettings : IGraphQLObject
{
    /// <summary>
    /// Banner customizations for the 'cookie banner'.
    /// </summary>
    [JsonPropertyName("banner")]
    public CookieBanner? banner { get; set; } = null;

    /// <summary>
    /// A shop's data sale opt out page (e.g. CCPA).
    /// </summary>
    [JsonPropertyName("dataSaleOptOutPage")]
    public DataSaleOptOutPage? dataSaleOptOutPage { get; set; } = null;

    /// <summary>
    /// A shop's privacy policy settings.
    /// </summary>
    [JsonPropertyName("privacyPolicy")]
    public PrivacyPolicy? privacyPolicy { get; set; } = null;
}