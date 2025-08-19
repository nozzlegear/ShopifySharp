#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for publications to which a collection will be published.
/// </summary>
public record CollectionPublicationInput : GraphQLInputObject<CollectionPublicationInput>
{
    /// <summary>
    /// The ID of the publication.
    /// </summary>
    [JsonPropertyName("publicationId")]
    public string? publicationId { get; set; } = null;
}