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
/// The input fields for specifying a publication to which a product will be published.
/// </summary>
public record ProductPublicationInput : GraphQLInputObject<ProductPublicationInput>
{
    /// <summary>
    /// ID of the publication.
    /// </summary>
    [JsonPropertyName("publicationId")]
    public string? publicationId { get; set; } = null;

    /// <summary>
    /// The date and time that the product was (or will be) published.
    /// </summary>
    [JsonPropertyName("publishDate")]
    public DateTimeOffset? publishDate { get; set; } = null;
}