#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The container border style.
/// </summary>
public enum CheckoutBrandingBorderStyle
{
    BASE,
    DASHED,
    DOTTED,
}