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
/// The input fields for updating a rate group for a value-based shipping option.
/// </summary>
public record DeliveryValueBasedRateGroupUpdateInput : GraphQLInputObject<DeliveryValueBasedRateGroupUpdateInput>
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
    /// Rates to create within this rate group.
    /// </summary>
    [JsonPropertyName("ratesToCreate")]
    public ICollection<DeliveryValueBasedRateCreateInput>? ratesToCreate { get; set; } = null;

    /// <summary>
    /// IDs of rates to delete from this rate group.
    /// </summary>
    [JsonPropertyName("ratesToDelete")]
    public ICollection<string>? ratesToDelete { get; set; } = null;

    /// <summary>
    /// Rates to update within this rate group.
    /// </summary>
    [JsonPropertyName("ratesToUpdate")]
    public ICollection<DeliveryValueBasedRateUpdateInput>? ratesToUpdate { get; set; } = null;
}