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
/// Identifies the [sales
/// channel](https://shopify.dev/docs/apps/build/sales-channels) and
/// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) from which
/// an [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
/// originated. Provides attribution details such as the specific platform (Facebook
/// Marketplace, Instagram Shopping) or marketplace where the order was placed.
/// Links to the app that manages the channel and optional [`ChannelDefinition`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ChannelDefinition)
/// details that specify the exact sub-channel or selling surface.
/// </summary>
public record ChannelInformation : IGraphQLObject, INode
{
    /// <summary>
    /// The app associated with the channel.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The channel definition associated with the channel.
    /// </summary>
    [JsonPropertyName("channelDefinition")]
    public ChannelDefinition? channelDefinition { get; set; } = null;

    /// <summary>
    /// The unique ID for the channel.
    /// </summary>
    [JsonPropertyName("channelId")]
    public string? channelId { get; set; } = null;

    /// <summary>
    /// The publishing destination display name or channel name.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}