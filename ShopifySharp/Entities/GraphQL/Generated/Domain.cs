#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A unique string that represents the address of a Shopify store on the Internet.
/// </summary>
public record Domain : IGraphQLObject, INode
{
    /// <summary>
    /// The host name of the domain. For example, `example.com`.
    /// </summary>
    [JsonPropertyName("host")]
    public string? host { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The localization of the domain, if the domain doesn't redirect.
    /// </summary>
    [JsonPropertyName("localization")]
    public DomainLocalization? localization { get; set; } = null;

    /// <summary>
    /// The web presence of the domain.
    /// </summary>
    [JsonPropertyName("marketWebPresence")]
    public MarketWebPresence? marketWebPresence { get; set; } = null;

    /// <summary>
    /// Whether SSL is enabled.
    /// </summary>
    [JsonPropertyName("sslEnabled")]
    public bool? sslEnabled { get; set; } = null;

    /// <summary>
    /// The URL of the domain (for example, `https://example.com`).
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}