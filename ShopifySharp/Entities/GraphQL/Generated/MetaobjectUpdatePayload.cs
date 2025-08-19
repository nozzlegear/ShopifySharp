#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `metaobjectUpdate` mutation.
/// </summary>
public record MetaobjectUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated metaobject.
    /// </summary>
    [JsonPropertyName("metaobject")]
    public Metaobject? metaobject { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}