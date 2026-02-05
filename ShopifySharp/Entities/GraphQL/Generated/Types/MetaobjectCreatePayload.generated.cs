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
/// Return type for `metaobjectCreate` mutation.
/// </summary>
public record MetaobjectCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created metaobject.
    /// </summary>
    [JsonPropertyName("metaobject")]
    public Metaobject? metaobject { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetaobjectUserError>? userErrors { get; set; } = null;
}