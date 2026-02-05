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
/// An app extension page for the customer account navigation menu.
/// </summary>
public record CustomerAccountAppExtensionPage : IGraphQLObject, ICustomerAccountPage, INavigable, INode
{
    /// <summary>
    /// The UUID of the app extension.
    /// </summary>
    [JsonPropertyName("appExtensionUuid")]
    public string? appExtensionUuid { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the customer account page.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The unique ID for the customer account page.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The title of the customer account page.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}