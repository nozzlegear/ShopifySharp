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
/// A shipping option with rates based on package weight.
/// Rates contain tiers that define package-weight thresholds. Checkout selects the
/// appropriate tier using the package weight of the shipping allocation, or the
/// combined package weight when allocations are grouped for weight conditions.
/// </summary>
public record DeliveryWeightBasedOptionDefinition : IGraphQLObject, IDeliveryOptionDefinition
{
    /// <summary>
    /// The currency used for all money values in this shipping option.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// Optional description shown to buyers.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The cart subtotal required for free shipping. Null if no threshold is set.
    /// </summary>
    [JsonPropertyName("freeDeliveryMinimumValue")]
    public MoneyV2? freeDeliveryMinimumValue { get; set; } = null;

    /// <summary>
    /// A globally unique ID for this shipping option.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Collections that any rate group in this shipping option applies to.
    /// </summary>
    [JsonPropertyName("includedCollections")]
    public CollectionConnection? includedCollections { get; set; } = null;

    /// <summary>
    /// Origin locations that any rate group in this shipping option applies to.
    /// </summary>
    [JsonPropertyName("includedLocations")]
    public LocationConnection? includedLocations { get; set; } = null;

    /// <summary>
    /// Whether this shipping option is active and shown to buyers.
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool? isActive { get; set; } = null;

    /// <summary>
    /// The name shown to buyers for this shipping option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The rate groups for this weight-based shipping option.
    /// </summary>
    [JsonPropertyName("rateGroups")]
    public DeliveryWeightBasedRateGroupConnection? rateGroups { get; set; } = null;
}