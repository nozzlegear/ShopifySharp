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
/// The input fields to create a price list adjustment.
/// </summary>
public record PriceListParentCreateInput : GraphQLInputObject<PriceListParentCreateInput>
{
    /// <summary>
    /// The relative adjustments to other prices.
    /// </summary>
    [JsonPropertyName("adjustment")]
    public PriceListAdjustmentInput? adjustment { get; set; } = null;

    /// <summary>
    /// The price list adjustment settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public PriceListAdjustmentSettingsInput? settings { get; set; } = null;
}