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
/// Type of a shipping package.
/// </summary>
public enum ShippingPackageType
{
    BOX,
    FLAT_RATE,
    ENVELOPE,
    SOFT_PACK,
}