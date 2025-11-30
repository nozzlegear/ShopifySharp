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
/// The URL for the homepage of the online store in the context of a particular market and a
/// particular locale.
/// </summary>
public record MarketWebPresenceRootUrl : IGraphQLObject
{
    /// <summary>
    /// The locale that the storefront loads in.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}