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
/// A checkout and account configuration override modifies a parent configuration for specific markets.
/// </summary>
public record CheckoutAndAccountsConfigurationOverride : IGraphQLObject, ICheckoutAndAccountsConfigurationInterface, INode
{
    /// <summary>
    /// The branding configuration.
    /// </summary>
    [JsonPropertyName("branding")]
    public CheckoutAndAccountsConfigurationBranding? branding { get; set; } = null;

    /// <summary>
    /// The date and time when the configuration was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The date and time when the configuration was last edited.
    /// </summary>
    [JsonPropertyName("editedAt")]
    public DateTimeOffset? editedAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The configuration name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The date and time when the configuration was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}