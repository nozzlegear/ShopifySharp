#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Systems of weights and measures.
/// </summary>
public enum UnitSystem
{
    IMPERIAL_SYSTEM,
    METRIC_SYSTEM,
}