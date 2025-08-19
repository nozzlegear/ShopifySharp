#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `publishableUnpublishToCurrentChannel` mutation.
/// </summary>
public record PublishableUnpublishToCurrentChannelPayload : IGraphQLObject
{
    /// <summary>
    /// Resource that has been unpublished.
    /// </summary>
    [JsonPropertyName("publishable")]
    public IPublishable? publishable { get; set; } = null;

    /// <summary>
    /// The user's shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}