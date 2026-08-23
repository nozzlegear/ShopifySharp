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
/// The input fields for updating a flat rate shipping option.
/// </summary>
public record DeliveryFlatRateOptionDefinitionUpdateInput : GraphQLInputObject<DeliveryFlatRateOptionDefinitionUpdateInput>
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
    /// The cart subtotal required for free shipping. Null clears the threshold.
    /// Currency must match the shipping option's currency.
    /// </summary>
    [JsonPropertyName("freeDeliveryMinimumValue")]
    public MoneyInput? freeDeliveryMinimumValue { get; set; } = null;

    /// <summary>
    /// The globally unique ID of the flat rate shipping option to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

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
    /// Rate groups to create for this shipping option.
    /// </summary>
    [JsonPropertyName("rateGroupsToCreate")]
    public ICollection<DeliveryFlatRateGroupCreateInput>? rateGroupsToCreate { get; set; } = null;

    /// <summary>
    /// The IDs of rate groups to delete from this shipping option.
    /// </summary>
    [JsonPropertyName("rateGroupsToDelete")]
    public ICollection<string>? rateGroupsToDelete { get; set; } = null;

    /// <summary>
    /// Rate groups to update for this shipping option.
    /// </summary>
    [JsonPropertyName("rateGroupsToUpdate")]
    public ICollection<DeliveryFlatRateGroupUpdateInput>? rateGroupsToUpdate { get; set; } = null;
}