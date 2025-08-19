#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `deliveryProfileCreate` mutation.
/// </summary>
public record DeliveryProfileCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The delivery profile that was created.
    /// </summary>
    [JsonPropertyName("profile")]
    public DeliveryProfile? profile { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}