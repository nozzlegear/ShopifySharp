#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The identifier for the metafield linked to this option.
/// This API is currently in early access. See [Metafield-linked product options](https://shopify.dev/docs/api/admin/migrate/new-product-model/metafield-linked)
/// for more details.
/// </summary>
public record LinkedMetafield : IGraphQLObject
{
    /// <summary>
    /// Key of the metafield the option is linked to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// Namespace of the metafield the option is linked to.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;
}