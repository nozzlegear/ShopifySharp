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
/// Return type for `productUpdateMedia` mutation.
/// </summary>
public record ProductUpdateMediaPayload : IGraphQLObject
{
    /// <summary>
    /// The updated media object.
    /// </summary>
    [JsonPropertyName("media")]
    public ICollection<IMedia>? media { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("mediaUserErrors")]
    public ICollection<MediaUserError>? mediaUserErrors { get; set; } = null;

    /// <summary>
    /// The product on which media was updated.
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