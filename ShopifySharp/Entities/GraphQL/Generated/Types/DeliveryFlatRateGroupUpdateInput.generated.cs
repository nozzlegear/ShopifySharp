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
/// The input fields for updating a flat rate group.
/// </summary>
public record DeliveryFlatRateGroupUpdateInput : GraphQLInputObject<DeliveryFlatRateGroupUpdateInput>
{
    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsUpdateInput? conditions { get; set; } = null;

    /// <summary>
    /// The globally unique ID of the flat rate group to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Updates to the fixed-price rate and optional transit time.
    /// </summary>
    [JsonPropertyName("rate")]
    public DeliveryFlatRateUpdateInput? rate { get; set; } = null;
}