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
/// The options for customizing the corner radius of checkout-related objects.
/// Examples include the primary button, the name text fields and the sections
/// within the main area (if they have borders).
/// </summary>
public enum CheckoutAndAccountsConfigurationBrandingCornerRadius
{
    NONE,
    SMALL,
    BASE,
    LARGE,
}