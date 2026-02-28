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
/// Metafields enable you to attach additional information to a Shopify resource, such
/// as a [Product](https://shopify.dev/api/admin-graphql/latest/objects/product) or
/// a [Collection](https://shopify.dev/api/admin-graphql/latest/objects/collection).
/// For more information about where you can attach metafields refer to [HasMetafields](https://shopify.dev/api/admin-graphql/latest/interfaces/HasMetafields).
/// Some examples of the data that metafields enable you to store are
/// specifications, size charts, downloadable documents, release dates, images, or part numbers.
/// Metafields are identified by an owner resource, namespace, and key. and store a
/// value along with type information for that value.
/// </summary>
public record Metafield : IGraphQLObject, IHasCompareDigest, ILegacyInteroperability, INode
{
    /// <summary>
    /// The data stored in the resource, represented as a digest.
    /// </summary>
    [JsonPropertyName("compareDigest")]
    public string? compareDigest { get; set; } = null;

    /// <summary>
    /// The date and time when the metafield was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The metafield definition that the metafield belongs to, if any.
    /// </summary>
    [JsonPropertyName("definition")]
    public MetafieldDefinition? definition { get; set; } = null;

    /// <summary>
    /// The description of the metafield.
    /// </summary>
    [JsonPropertyName("description")]
    [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The data stored in the metafield in JSON format.
    /// </summary>
    [JsonPropertyName("jsonValue")]
    public string? jsonValue { get; set; } = null;

    /// <summary>
    /// The unique identifier for the metafield within its namespace.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield is associated with.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The resource that the metafield is attached to.
    /// </summary>
    [JsonPropertyName("owner")]
    public IHasMetafields? owner { get; set; } = null;

    /// <summary>
    /// The type of resource that the metafield is attached to.
    /// </summary>
    [JsonPropertyName("ownerType")]
    public MetafieldOwnerType? ownerType { get; set; } = null;

    /// <summary>
    /// Returns a reference object if the metafield definition's type is a resource reference.
    /// </summary>
    [JsonPropertyName("reference")]
    public MetafieldReference? reference { get; set; } = null;

    /// <summary>
    /// A list of reference objects if the metafield's type is a resource reference list.
    /// </summary>
    [JsonPropertyName("references")]
    public MetafieldReferenceConnection? references { get; set; } = null;

    /// <summary>
    /// The type of data that's stored in the metafield.
    /// Refer to the list of [supported types](https://shopify.dev/apps/metafields/types).
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// The date and time when the metafield was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;

    /// <summary>
    /// The data stored in the metafield. Always stored as a string, regardless of the metafield's type.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}