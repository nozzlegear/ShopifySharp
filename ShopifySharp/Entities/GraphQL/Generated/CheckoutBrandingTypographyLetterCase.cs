#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible values for the typography letter case.
/// </summary>
public enum CheckoutBrandingTypographyLetterCase
{
    LOWER,
    NONE,
    TITLE,
    UPPER,
}