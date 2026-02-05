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
/// Return type for `locationDelete` mutation.
/// </summary>
public record LocationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the location that was deleted.
    /// </summary>
    [JsonPropertyName("deletedLocationId")]
    public string? deletedLocationId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("locationDeleteUserErrors")]
    public ICollection<LocationDeleteUserError>? locationDeleteUserErrors { get; set; } = null;
}