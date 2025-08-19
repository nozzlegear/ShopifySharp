#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishDate { get; set; } = null;
}