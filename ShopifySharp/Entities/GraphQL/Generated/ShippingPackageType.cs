#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Type of a shipping package.
/// </summary>
public enum ShippingPackageType
{
    BOX,
    FLAT_RATE,
    ENVELOPE,
    SOFT_PACK,
}