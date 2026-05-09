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
/// The input fields for creating a [`Channel`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
/// </summary>
public record ChannelCreateInput : GraphQLInputObject<ChannelCreateInput>
{
    /// <summary>
    /// A unique identifier for the merchant's account on the external platform, such
    /// as an Amazon Seller ID or Google Merchant Center ID. Used together with
    /// `specificationHandle` to uniquely identify the channel connection.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? accountId { get; set; } = null;

    /// <summary>
    /// The merchant-facing name for the external account. Displayed in Shopify Admin
    /// wherever the channel connection is referenced, such as in Markets and order
    /// attribution. Should match how the merchant recognises the account on the
    /// external platform.
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? accountName { get; set; } = null;

    /// <summary>
    /// A unique, human-readable identifier for the channel within the shop. For
    /// example, `amazon-us-A1B2C3D4E5F6G7`. Used for lookups via [`channelByHandle`](https://shopify.dev/docs/api/admin-graphql/latest/queries/channelByHandle).
    /// If not provided, auto-generated from the specification handle and account ID.
    /// Must be unique across all channels on the shop.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The handle of the [channel specification](https://shopify.dev/docs/apps/build/sales-channels/channel-config-extension)
    /// to bind to this channel. The specification must have been deployed by the
    /// calling application via `shopify app deploy`. Determines the channel's
    /// regional coverage, capabilities, and requirements.
    /// </summary>
    [JsonPropertyName("specificationHandle")]
    public string? specificationHandle { get; set; } = null;
}