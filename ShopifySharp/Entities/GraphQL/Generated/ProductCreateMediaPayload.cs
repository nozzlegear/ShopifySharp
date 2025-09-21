#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productCreateMedia` mutation.
/// </summary>
public record ProductCreateMediaPayload : IGraphQLObject
{
    /// <summary>
    /// The newly created media.
    /// </summary>
    [JsonPropertyName("media")]
    public ICollection<IMedia>? media { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("mediaUserErrors")]
    public ICollection<MediaUserError>? mediaUserErrors { get; set; } = null;

    /// <summary>
    /// The product associated with the media.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    [Obsolete("Use `mediaUserErrors` instead.")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}