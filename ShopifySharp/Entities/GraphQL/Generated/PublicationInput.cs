#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to publish a resource.
/// </summary>
public record PublicationInput : GraphQLInputObject<PublicationInput>
{
    /// <summary>
    /// ID of the publication.
    /// </summary>
    [JsonPropertyName("publicationId")]
    public string? publicationId { get; set; } = null;

    /// <summary>
    /// The date and time that the resource was published. Setting this to a date in
    /// the future will schedule the resource to be published. Only online store
    /// channels support future publishing. This field has no effect if you include it
    /// in the `publishableUnpublish` mutation.
    /// </summary>
    [JsonPropertyName("publishDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishDate { get; set; } = null;
}