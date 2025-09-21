#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A channel definition represents channels surfaces on the platform.
/// A channel definition can be a platform or a subsegment of it such as Facebook
/// Home, Instagram Live, Instagram Shops, or WhatsApp chat.
/// </summary>
public record ChannelDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// Name of the channel that this sub channel belongs to.
    /// </summary>
    [JsonPropertyName("channelName")]
    public string? channelName { get; set; } = null;

    /// <summary>
    /// Unique string used as a public identifier for the channel definition.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The unique ID for the channel definition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether this channel definition represents a marketplace.
    /// </summary>
    [JsonPropertyName("isMarketplace")]
    public bool? isMarketplace { get; set; } = null;

    /// <summary>
    /// Name of the sub channel (e.g. Online Store, Instagram Shopping, TikTok Live).
    /// </summary>
    [JsonPropertyName("subChannelName")]
    public string? subChannelName { get; set; } = null;

    /// <summary>
    /// Icon displayed when showing the channel in admin.
    /// </summary>
    [JsonPropertyName("svgIcon")]
    [Obsolete("Use App.icon instead")]
    public string? svgIcon { get; set; } = null;
}