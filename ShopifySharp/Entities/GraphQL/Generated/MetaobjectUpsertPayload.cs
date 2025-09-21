#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `metaobjectUpsert` mutation.
/// </summary>
public record MetaobjectUpsertPayload : IGraphQLObject
{
    /// <summary>
    /// The created or updated metaobject.
    /// </summary>
    [JsonPropertyName("metaobject")]
    public Metaobject? metaobject { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}