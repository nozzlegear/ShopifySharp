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
/// A specific selling surface within a [sales
/// channel](https://shopify.dev/docs/apps/build/sales-channels) platform. A channel
/// definition identifies where products can be sold. Definitions can represent
/// entire platforms (like Facebook or TikTok) or specific sales channels within
/// those platforms, such as Instagram Shops, Instagram Shopping, or TikTok Live.
/// Each definition includes the parent
/// [`Channel`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel)
/// name and subchannel name to indicate the selling surface hierarchy. The
/// marketplace flag identifies whether this surface represents a marketplace
/// channel such as shops on Facebook, Instagram, or Buy on Google.
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