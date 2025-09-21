#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `carrierServiceUpdate` mutation.
/// </summary>
public record CarrierServiceUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated carrier service.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CarrierServiceUpdateUserError>? userErrors { get; set; } = null;
}