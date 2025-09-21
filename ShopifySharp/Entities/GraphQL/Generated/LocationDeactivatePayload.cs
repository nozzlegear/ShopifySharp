#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `locationDeactivate` mutation.
/// </summary>
public record LocationDeactivatePayload : IGraphQLObject
{
    /// <summary>
    /// The location that was deactivated.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("locationDeactivateUserErrors")]
    public ICollection<LocationDeactivateUserError>? locationDeactivateUserErrors { get; set; } = null;
}