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
/// The possible color schemes.
/// </summary>
public enum CheckoutBrandingColorSchemeSelection
{
    TRANSPARENT,
    COLOR_SCHEME1,
    COLOR_SCHEME2,
    COLOR_SCHEME3,
    COLOR_SCHEME4,
}