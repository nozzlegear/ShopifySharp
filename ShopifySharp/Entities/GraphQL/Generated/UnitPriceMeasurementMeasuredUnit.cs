#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid units of measurement for a unit price measurement.
/// </summary>
public enum UnitPriceMeasurementMeasuredUnit
{
    ML,
    CL,
    L,
    M3,
    FLOZ,
    PT,
    QT,
    GAL,
    MG,
    G,
    KG,
    OZ,
    LB,
    MM,
    CM,
    M,
    IN,
    FT,
    YD,
    M2,
    FT2,
    ITEM,
    UNKNOWN,
}