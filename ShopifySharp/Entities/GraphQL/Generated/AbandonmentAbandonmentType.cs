#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies the abandonment type.
/// </summary>
public enum AbandonmentAbandonmentType
{
    BROWSE,
    CART,
    CHECKOUT,
}