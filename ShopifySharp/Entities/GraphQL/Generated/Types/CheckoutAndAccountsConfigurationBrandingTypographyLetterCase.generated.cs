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
/// Possible values for the typography letter case.
/// </summary>
public enum CheckoutAndAccountsConfigurationBrandingTypographyLetterCase
{
    LOWER,
    NONE,
    TITLE,
    UPPER,
}