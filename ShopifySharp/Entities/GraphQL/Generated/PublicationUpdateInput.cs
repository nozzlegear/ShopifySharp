#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a publication.
/// </summary>
public record PublicationUpdateInput : GraphQLInputObject<PublicationUpdateInput>
{
    /// <summary>
    /// Whether new products should be automatically published to the publication.
    /// </summary>
    [JsonPropertyName("autoPublish")]
    public bool? autoPublish { get; set; } = null;

    /// <summary>
    /// A list of publishable IDs to add. The maximum number of publishables to update simultaneously is 50.
    /// </summary>
    [JsonPropertyName("publishablesToAdd")]
    public ICollection<string>? publishablesToAdd { get; set; } = null;

    /// <summary>
    /// A list of publishable IDs to remove. The maximum number of publishables to update simultaneously is 50.
    /// </summary>
    [JsonPropertyName("publishablesToRemove")]
    public ICollection<string>? publishablesToRemove { get; set; } = null;
}