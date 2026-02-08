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
/// Return type for `serverPixelDelete` mutation.
/// </summary>
public record ServerPixelDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the server pixel that was deleted, if one was deleted.
    /// </summary>
    [JsonPropertyName("deletedServerPixelId")]
    public string? deletedServerPixelId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsServerPixelUserError>? userErrors { get; set; } = null;
}