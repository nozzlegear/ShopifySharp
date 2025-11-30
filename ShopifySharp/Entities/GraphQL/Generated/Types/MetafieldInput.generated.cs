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
/// The input fields to use to create or update a metafield through a mutation on the owning resource.
/// An alternative way to create or update a metafield is by using the
/// [metafieldsSet](https://shopify.dev/api/admin-graphql/latest/mutations/metafieldsSet) mutation.
/// </summary>
public record MetafieldInput : GraphQLInputObject<MetafieldInput>
{
    /// <summary>
    /// The unique ID of the metafield. Using `owner_id`, `namespace`, and `key` is preferred for creating and updating.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The unique identifier for a metafield within its namespace.
    /// Required when creating a metafield, but optional when updating. Used to help identify the metafield when
    /// updating, but can't be updated itself.
    /// Must be 2-64 characters long and can contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield is or will be associated with. Used in tandem with
    /// `key` to lookup a metafield on a resource, preventing conflicts with other metafields with the same `key`.
    /// Required when creating a metafield, but optional when updating. Used to help identify the metafield when
    /// updating, but can't be updated itself.
    /// Must be 3-255 characters long and can contain alphanumeric, hyphen, and underscore characters.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The type of data that is stored in the metafield.
    /// Refer to the list of [supported types](https://shopify.dev/apps/metafields/types).
    /// Required when creating or updating a metafield without a definition.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// The data stored in the metafield. Always stored as a string, regardless of the metafield's type.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}