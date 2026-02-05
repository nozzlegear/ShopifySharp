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
/// Identifies the [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) that
/// created an order. Common sources include "online store" for web purchases,
/// "Point of Sale" for in-person sales, or custom app names for orders created
/// through third-party integrations.
/// Use this information to track order attribution, analyze sales channels, and
/// route orders to appropriate fulfillment workflows based on their source.
/// </summary>
public record OrderApp : IGraphQLObject
{
    /// <summary>
    /// The application icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public Image? icon { get; set; } = null;

    /// <summary>
    /// The application ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the application.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}