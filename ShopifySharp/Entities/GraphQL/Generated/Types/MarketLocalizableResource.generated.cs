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
/// A resource that has market localizable fields.
/// </summary>
public record MarketLocalizableResource : IGraphQLObject
{
    /// <summary>
    /// The market localizable content.
    /// </summary>
    [JsonPropertyName("marketLocalizableContent")]
    public ICollection<MarketLocalizableContent>? marketLocalizableContent { get; set; } = null;

    /// <summary>
    /// Market localizations for the market localizable content.
    /// </summary>
    [JsonPropertyName("marketLocalizations")]
    public ICollection<MarketLocalization>? marketLocalizations { get; set; } = null;

    /// <summary>
    /// The GID of the resource.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? resourceId { get; set; } = null;
}