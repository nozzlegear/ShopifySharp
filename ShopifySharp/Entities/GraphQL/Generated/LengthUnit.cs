#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Units of measurement for length.
/// </summary>
public enum LengthUnit
{
    MILLIMETERS,
    CENTIMETERS,
    METERS,
    INCHES,
    FEET,
    YARDS,
}