#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Interoperability metadata for types that directly correspond to a REST Admin API resource.
/// For example, on the Product type, LegacyInteroperability returns metadata for
/// the corresponding [Product
/// object](https://shopify.dev/api/admin-graphql/latest/objects/product) in the
/// REST Admin API.
/// </summary>
public interface ILegacyInteroperability : IGraphQLObject
{
    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; }
}