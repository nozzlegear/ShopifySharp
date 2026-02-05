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
/// The input fields for specifying a product to unpublish from a channel and the sales channels to unpublish it from.
/// </summary>
public record ProductUnpublishInput : GraphQLInputObject<ProductUnpublishInput>
{
    /// <summary>
    /// The ID of the product to create or update publications for.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The channels to unpublish the product from.
    /// </summary>
    [JsonPropertyName("productPublications")]
    public ICollection<ProductPublicationInput>? productPublications { get; set; } = null;
}