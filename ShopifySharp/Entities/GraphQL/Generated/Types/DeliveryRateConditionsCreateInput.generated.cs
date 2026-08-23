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
/// The input fields for conditions that limit a rate group to specific collections or origin locations.
/// </summary>
public record DeliveryRateConditionsCreateInput : GraphQLInputObject<DeliveryRateConditionsCreateInput>
{
    /// <summary>
    /// Collection IDs to add. The rate group applies only to products in these collections.
    /// </summary>
    [JsonPropertyName("collectionsToAdd")]
    public ICollection<string>? collectionsToAdd { get; set; } = null;

    /// <summary>
    /// Origin location IDs to add. The rate group applies only to shipments from these locations.
    /// </summary>
    [JsonPropertyName("originLocationsToAdd")]
    public ICollection<string>? originLocationsToAdd { get; set; } = null;
}