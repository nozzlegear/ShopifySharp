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
/// Possible choices for the font size.
/// </summary>
public enum CheckoutAndAccountsConfigurationBrandingTypographySize
{
    EXTRA_SMALL,
    SMALL,
    BASE,
    MEDIUM,
    LARGE,
    EXTRA_LARGE,
    EXTRA_EXTRA_LARGE,
}