#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible values for the typography kerning.
/// </summary>
public enum CheckoutBrandingTypographyKerning
{
    BASE,
    LOOSE,
    EXTRA_LOOSE,
}