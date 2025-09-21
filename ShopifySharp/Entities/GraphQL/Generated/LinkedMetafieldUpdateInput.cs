#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to link a product option to a metafield.
/// This API is currently in early access. See [Metafield-linked product options](https://shopify.dev/docs/api/admin/migrate/new-product-model/metafield-linked)
/// for more details.
/// </summary>
public record LinkedMetafieldUpdateInput : GraphQLInputObject<LinkedMetafieldUpdateInput>
{
    /// <summary>
    /// The key of the metafield this option is linked to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield this option is linked to.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;
}