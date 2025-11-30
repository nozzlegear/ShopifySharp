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