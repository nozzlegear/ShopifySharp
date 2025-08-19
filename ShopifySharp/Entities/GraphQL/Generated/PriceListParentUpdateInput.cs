#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update a price list's adjustment.
/// </summary>
public record PriceListParentUpdateInput : GraphQLInputObject<PriceListParentUpdateInput>
{
    /// <summary>
    /// The relative adjustments to other prices..
    /// </summary>
    [JsonPropertyName("adjustment")]
    public PriceListAdjustmentInput? adjustment { get; set; } = null;

    /// <summary>
    /// The price list adjustment settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public PriceListAdjustmentSettingsInput? settings { get; set; } = null;
}