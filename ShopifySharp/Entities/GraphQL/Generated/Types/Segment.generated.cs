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
/// A group of [customers](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// that meet specific criteria defined through [ShopifyQL
/// query](https://shopify.dev/docs/api/shopifyql/segment-query-language-reference)
/// conditions. Common use cases for segments include customer analytics, targeted
/// marketing campaigns, and automated discount eligibility.
/// The segment's [`query`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment#field-query) field contains ShopifyQL conditions that determine membership, such as purchase
/// history, location, or engagement patterns. Tracks when the segment was created with [`creationDate`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment#field-creationDate)
/// and when it was last modified with [`lastEditDate`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Segment#field-lastEditDate).
/// </summary>
public record Segment : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the segment was added to the store.
    /// </summary>
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? creationDate { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The date and time when the segment was last updated.
    /// </summary>
    [JsonPropertyName("lastEditDate")]
    public DateTimeOffset? lastEditDate { get; set; } = null;

    /// <summary>
    /// The name of the segment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A precise definition of the segment. The definition is composed of a combination of conditions on facts about customers.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;
}