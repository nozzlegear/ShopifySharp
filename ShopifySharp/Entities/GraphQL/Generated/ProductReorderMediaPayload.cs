#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productReorderMedia` mutation.
/// </summary>
public record ProductReorderMediaPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job which reorders the media.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("mediaUserErrors")]
    public ICollection<MediaUserError>? mediaUserErrors { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    [Obsolete("Use `mediaUserErrors` instead.")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}