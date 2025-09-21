#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible values for the border.
/// </summary>
public enum CheckoutBrandingBorder
{
    NONE,
    BLOCK_END,
    FULL,
}