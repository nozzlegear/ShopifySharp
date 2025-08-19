#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the Adjustments query.
/// </summary>
public enum AdjustmentsSortKeys
{
    ID,
    TIME,
}