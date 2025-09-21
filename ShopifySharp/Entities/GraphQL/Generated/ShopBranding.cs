#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible branding of a shop.
/// Branding can be used to define the look of a shop including its styling and logo in the Shopify Admin.
/// </summary>
public enum ShopBranding
{
    SHOPIFY_GOLD,
    SHOPIFY_PLUS,
    ROGERS,
    SHOPIFY,
}