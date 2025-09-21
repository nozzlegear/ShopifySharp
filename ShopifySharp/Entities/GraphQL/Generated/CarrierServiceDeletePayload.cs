#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `carrierServiceDelete` mutation.
/// </summary>
public record CarrierServiceDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted carrier service.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CarrierServiceDeleteUserError>? userErrors { get; set; } = null;
}