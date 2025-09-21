#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to set a price list's adjustment settings.
/// </summary>
public record PriceListAdjustmentSettingsInput : GraphQLInputObject<PriceListAdjustmentSettingsInput>
{
    /// <summary>
    /// Determines how adjustments are applied to compare at prices.
    /// </summary>
    [JsonPropertyName("compareAtMode")]
    public PriceListCompareAtMode? compareAtMode { get; set; } = null;
}