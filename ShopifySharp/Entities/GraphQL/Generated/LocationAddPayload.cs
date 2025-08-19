#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `locationAdd` mutation.
/// </summary>
public record LocationAddPayload : IGraphQLObject
{
    /// <summary>
    /// The location that was added.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<LocationAddUserError>? userErrors { get; set; } = null;
}