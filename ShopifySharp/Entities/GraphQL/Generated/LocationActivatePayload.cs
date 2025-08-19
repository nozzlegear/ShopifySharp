#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `locationActivate` mutation.
/// </summary>
public record LocationActivatePayload : IGraphQLObject
{
    /// <summary>
    /// The location that was activated.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("locationActivateUserErrors")]
    public ICollection<LocationActivateUserError>? locationActivateUserErrors { get; set; } = null;
}