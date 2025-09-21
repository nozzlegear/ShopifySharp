#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The container background style.
/// </summary>
public enum CheckoutBrandingBackground
{
    BASE,
    SUBDUED,
    TRANSPARENT,
}