#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible values for the spacing.
/// </summary>
public enum CheckoutBrandingSpacing
{
    NONE,
    EXTRA_TIGHT,
    TIGHT,
    BASE,
    LOOSE,
    EXTRA_LOOSE,
}