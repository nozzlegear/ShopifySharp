#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

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