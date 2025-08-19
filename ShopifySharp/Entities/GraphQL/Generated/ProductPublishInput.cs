#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying a product to publish and the channels to publish it to.
/// </summary>
public record ProductPublishInput : GraphQLInputObject<ProductPublishInput>
{
    /// <summary>
    /// The product to create or update publications for.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The publication that the product is published to.
    /// </summary>
    [JsonPropertyName("productPublications")]
    public ICollection<ProductPublicationInput>? productPublications { get; set; } = null;
}