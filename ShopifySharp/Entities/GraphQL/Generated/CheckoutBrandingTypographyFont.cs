#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The font selection.
/// </summary>
public enum CheckoutBrandingTypographyFont
{
    PRIMARY,
    SECONDARY,
}