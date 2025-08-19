#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible header positions.
/// </summary>
public enum CheckoutBrandingHeaderPosition
{
    INLINE,
    INLINE_SECONDARY,
    START,
}