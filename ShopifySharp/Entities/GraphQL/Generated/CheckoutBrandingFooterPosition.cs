#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible values for the footer position.
/// </summary>
public enum CheckoutBrandingFooterPosition
{
    END,
    INLINE,
}