#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The accepted types of unit of measurement.
/// </summary>
public enum UnitPriceMeasurementMeasuredType
{
    VOLUME,
    WEIGHT,
    LENGTH,
    AREA,
    COUNT,
    UNKNOWN,
}