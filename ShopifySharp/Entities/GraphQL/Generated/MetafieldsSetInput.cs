#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a metafield value to set.
/// </summary>
public record MetafieldsSetInput : GraphQLInputObject<MetafieldsSetInput>
{
    /// <summary>
    /// The `compareDigest` value obtained from a previous query. Provide this with
    /// updates to ensure the metafield is modified safely.
    /// </summary>
    [JsonPropertyName("compareDigest")]
    public string? compareDigest { get; set; } = null;

    /// <summary>
    /// The unique identifier for a metafield within its namespace.
    /// Must be 2-64 characters long and can contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield is or will be associated with. Used in tandem
    /// with `key` to lookup a metafield on a resource, preventing conflicts with other metafields with the
    /// same `key`. If omitted the app-reserved namespace will be used.
    /// Must be 3-255 characters long and can contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The unique ID of the resource that the metafield is attached to.
    /// </summary>
    [JsonPropertyName("ownerId")]
    public string? ownerId { get; set; } = null;

    /// <summary>
    /// The type of data that is stored in the metafield.
    /// The type must be one of the [supported types](https://shopify.dev/apps/metafields/types).
    /// Required when there is no corresponding definition for the given `namespace`, `key`, and
    /// owner resource type (derived from `ownerId`).
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// The data stored in the metafield. Always stored as a string, regardless of the metafield's type.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}