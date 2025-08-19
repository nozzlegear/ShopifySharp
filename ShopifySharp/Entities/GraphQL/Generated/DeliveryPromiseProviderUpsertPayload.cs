#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `deliveryPromiseProviderUpsert` mutation.
/// </summary>
public record DeliveryPromiseProviderUpsertPayload : IGraphQLObject
{
    /// <summary>
    /// The created or updated delivery promise provider.
    /// </summary>
    [JsonPropertyName("deliveryPromiseProvider")]
    public DeliveryPromiseProvider? deliveryPromiseProvider { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryPromiseProviderUpsertUserError>? userErrors { get; set; } = null;
}