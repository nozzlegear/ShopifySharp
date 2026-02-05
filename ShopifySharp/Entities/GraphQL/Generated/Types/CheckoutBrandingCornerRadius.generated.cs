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
/// The options for customizing the corner radius of checkout-related objects. Examples include the primary
/// button, the name text fields and the sections within the main area (if they have borders).
/// Refer to this complete [list](https://shopify.dev/docs/api/admin-graphql/latest/enums/CheckoutBrandingCornerRadius#fieldswith)
/// for objects with customizable corner radii.
/// The design system defines the corner radius pixel size for each option. Modify the defaults by setting the
/// [designSystem.cornerRadius](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/CheckoutBrandingDesignSystemInput#field-checkoutbrandingdesignsysteminput-cornerradius)
/// input fields.
/// </summary>
public enum CheckoutBrandingCornerRadius
{
    NONE,
    SMALL,
    BASE,
    LARGE,
}