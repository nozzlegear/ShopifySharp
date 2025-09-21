#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The container shadow.
/// </summary>
public enum CheckoutBrandingShadow
{
    SMALL_200,
    SMALL_100,
    BASE,
    LARGE_100,
    LARGE_200,
}