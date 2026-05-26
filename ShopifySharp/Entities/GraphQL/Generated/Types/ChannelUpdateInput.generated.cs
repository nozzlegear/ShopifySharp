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
/// The input fields for updating a [`Channel`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
/// </summary>
public record ChannelUpdateInput : GraphQLInputObject<ChannelUpdateInput>
{
    /// <summary>
    /// An updated identifier for the merchant's account on the external platform.
    /// Changing this value signals that the channel connection now represents a
    /// different external account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? accountId { get; set; } = null;

    /// <summary>
    /// An updated merchant-facing name for the external account. Displayed in Shopify
    /// Admin when multiple channels exist for the same app, to help merchants
    /// distinguish between connections.
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? accountName { get; set; } = null;

    /// <summary>
    /// A new unique identifier for the channel within the shop. Must be unique across
    /// all channels on the shop. Handles are typically set at creation and rarely
    /// changed — use when correcting a handle or migrating legacy channel records.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The handle of the [channel specification](https://shopify.dev/docs/apps/build/sales-channels/channel-config-extension)
    /// to bind to this channel. When changed, the platform re-evaluates the
    /// specification's country coverage against the shop's region markets and
    /// reconciles product feeds accordingly.
    /// </summary>
    [JsonPropertyName("specificationHandle")]
    public string? specificationHandle { get; set; } = null;
}