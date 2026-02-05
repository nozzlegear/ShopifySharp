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
/// The measurement used to calculate a unit price for a product variant (e.g. $9.99 / 100ml).
/// </summary>
public record UnitPriceMeasurement : IGraphQLObject
{
    /// <summary>
    /// The type of unit of measurement for the unit price measurement.
    /// </summary>
    [JsonPropertyName("measuredType")]
    public UnitPriceMeasurementMeasuredType? measuredType { get; set; } = null;

    /// <summary>
    /// The quantity unit for the unit price measurement.
    /// </summary>
    [JsonPropertyName("quantityUnit")]
    public UnitPriceMeasurementMeasuredUnit? quantityUnit { get; set; } = null;

    /// <summary>
    /// The quantity value for the unit price measurement.
    /// </summary>
    [JsonPropertyName("quantityValue")]
    public decimal? quantityValue { get; set; } = null;

    /// <summary>
    /// The reference unit for the unit price measurement.
    /// </summary>
    [JsonPropertyName("referenceUnit")]
    public UnitPriceMeasurementMeasuredUnit? referenceUnit { get; set; } = null;

    /// <summary>
    /// The reference value for the unit price measurement.
    /// </summary>
    [JsonPropertyName("referenceValue")]
    public int? referenceValue { get; set; } = null;
}