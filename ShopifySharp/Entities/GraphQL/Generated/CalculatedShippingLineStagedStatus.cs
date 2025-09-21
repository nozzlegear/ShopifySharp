#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the staged status of a CalculatedShippingLine on a CalculatedOrder.
/// </summary>
public enum CalculatedShippingLineStagedStatus
{
    NONE,
    ADDED,
    REMOVED,
}