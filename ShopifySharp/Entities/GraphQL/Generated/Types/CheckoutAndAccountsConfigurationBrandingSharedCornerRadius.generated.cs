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
/// Possible choices to override corner radius customizations on all applicable
/// objects. Note that this selection can only be used to set the override to `NONE` (0px).
/// </summary>
public enum CheckoutAndAccountsConfigurationBrandingSharedCornerRadius
{
    NONE,
}