#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Units of measurement for distance.
/// </summary>
public enum DistanceUnit
{
    KILOMETERS,
    MILES,
}