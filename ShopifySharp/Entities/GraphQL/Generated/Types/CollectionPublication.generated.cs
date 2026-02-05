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
/// Represents the publication status and settings for a collection across different
/// sales channels. This tracks where collections are published, when they were
/// published, and any channel-specific configuration.
/// For example, a "Holiday Gifts" collection might be published to the online store
/// and Facebook Shop but not to the POS channel, with different publication dates
/// for each channel based on marketing strategy.
/// Use `CollectionPublication` to:
/// - Track collection visibility across multiple sales channels
/// - Manage channel-specific collection settings and availability
/// - Monitor publication history and timing for collections
/// - Control where collections appear in customer-facing channels
/// - Implement channel-specific collection management workflows
/// Each publication record includes the channel information, publication status,
/// and timing details. This enables merchants to control collection visibility
/// strategically across their sales channels.
/// Collections can have different publication settings per channel, allowing for
/// targeted marketing and inventory management. For instance, wholesale collections
/// might only be published to B2B channels while retail collections appear in
/// consumer-facing channels.
/// The publication system integrates with Shopify's broader channel management,
/// ensuring collections appear consistently across the merchant's sales ecosystem
/// while respecting channel-specific rules and permissions.
/// Learn more about [sales channel management](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
/// </summary>
public record CollectionPublication : IGraphQLObject
{
    /// <summary>
    /// The channel where the collection will be published.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// The collection to be published on the publication.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// Whether the publication is published or not.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The publication where the collection will be published.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The date that the publication was or is going to be published.
    /// </summary>
    [JsonPropertyName("publishDate")]
    public DateTimeOffset? publishDate { get; set; } = null;
}