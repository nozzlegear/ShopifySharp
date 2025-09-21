#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible choices to override corner radius customizations on all applicable objects. Note that this selection 
/// can only be used to set the override to `NONE` (0px).
/// For more customizations options, set the [corner radius](https://shopify.dev/docs/api/admin-graphql/latest/enums/CheckoutBrandingCornerRadius)
/// selection on specific objects while leaving the global corner radius unset.
/// </summary>
public enum CheckoutBrandingGlobalCornerRadius
{
    NONE,
}