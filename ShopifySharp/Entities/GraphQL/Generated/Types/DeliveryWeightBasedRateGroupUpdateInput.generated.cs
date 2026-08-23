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
/// The input fields for updating a weight-based rate group.
/// </summary>
public record DeliveryWeightBasedRateGroupUpdateInput : GraphQLInputObject<DeliveryWeightBasedRateGroupUpdateInput>
{
    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsUpdateInput? conditions { get; set; } = null;

    /// <summary>
    /// The ID of the rate group to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Rates to create in this rate group.
    /// </summary>
    [JsonPropertyName("ratesToCreate")]
    public ICollection<DeliveryWeightBasedRateCreateInput>? ratesToCreate { get; set; } = null;

    /// <summary>
    /// IDs of rates to delete from this rate group.
    /// </summary>
    [JsonPropertyName("ratesToDelete")]
    public ICollection<string>? ratesToDelete { get; set; } = null;

    /// <summary>
    /// Rates to update in this rate group.
    /// </summary>
    [JsonPropertyName("ratesToUpdate")]
    public ICollection<DeliveryWeightBasedRateUpdateInput>? ratesToUpdate { get; set; } = null;
}