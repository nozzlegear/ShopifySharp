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
/// An app together with the shareable collection sources it publishes for the shop.
/// </summary>
public record CollectionConditionsSourcesByApp : IGraphQLObject
{
    /// <summary>
    /// The app that publishes the collection sources.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The shareable collection sources owned by this app.
    /// </summary>
    [JsonPropertyName("sources")]
    public CollectionConditionsSourceConnection? sources { get; set; } = null;
}