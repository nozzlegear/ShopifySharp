#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Units of measurement for weight.
/// </summary>
public enum WeightUnit
{
    KILOGRAMS,
    GRAMS,
    POUNDS,
    OUNCES,
}