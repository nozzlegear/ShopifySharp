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
/// The input fields for updating a carrier-calculated shipping option.
/// </summary>
public record DeliveryCarrierCalculatedOptionDefinitionUpdateInput : GraphQLInputObject<DeliveryCarrierCalculatedOptionDefinitionUpdateInput>
{
    /// <summary>
    /// The currency used for all money values in this shipping option.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// Description shown to buyers.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The cart subtotal required for free shipping. Null clears the existing
    /// threshold. Currency must match the shipping option's currency.
    /// </summary>
    [JsonPropertyName("freeDeliveryMinimumValue")]
    public MoneyInput? freeDeliveryMinimumValue { get; set; } = null;

    /// <summary>
    /// The ID of the carrier-calculated shipping option to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether this shipping option is active and shown to buyers.
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool? isActive { get; set; } = null;

    /// <summary>
    /// Rate groups to create for this shipping option. At this time, only a single
    /// rate group is supported for carrier calculated shipping options.
    /// </summary>
    [JsonPropertyName("rateGroupsToCreate")]
    public ICollection<DeliveryCarrierCalculatedRateGroupCreateInput>? rateGroupsToCreate { get; set; } = null;

    /// <summary>
    /// The IDs of rate groups to delete from this shipping option.
    /// </summary>
    [JsonPropertyName("rateGroupsToDelete")]
    public ICollection<string>? rateGroupsToDelete { get; set; } = null;

    /// <summary>
    /// Rate groups to update for this shipping option. Only the existing single rate group is supported.
    /// </summary>
    [JsonPropertyName("rateGroupsToUpdate")]
    public ICollection<DeliveryCarrierCalculatedRateGroupUpdateInput>? rateGroupsToUpdate { get; set; } = null;
}