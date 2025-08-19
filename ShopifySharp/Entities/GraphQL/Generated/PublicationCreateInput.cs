#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a publication.
/// </summary>
public record PublicationCreateInput : GraphQLInputObject<PublicationCreateInput>
{
    /// <summary>
    /// Whether to automatically add newly created products to this publication.
    /// </summary>
    [JsonPropertyName("autoPublish")]
    public bool? autoPublish { get; set; } = null;

    /// <summary>
    /// The ID of the catalog.
    /// </summary>
    [JsonPropertyName("catalogId")]
    public string? catalogId { get; set; } = null;

    /// <summary>
    /// Whether to create an empty publication or prepopulate it with all products.
    /// </summary>
    [JsonPropertyName("defaultState")]
    public PublicationCreateInputPublicationDefaultState? defaultState { get; set; } = null;
}