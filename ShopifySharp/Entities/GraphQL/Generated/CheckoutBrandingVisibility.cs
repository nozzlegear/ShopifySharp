#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible visibility states.
/// </summary>
public enum CheckoutBrandingVisibility
{
    HIDDEN,
    VISIBLE,
}