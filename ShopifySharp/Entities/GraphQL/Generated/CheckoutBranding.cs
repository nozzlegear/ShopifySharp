#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The settings of checkout visual customizations.
/// To learn more about updating checkout branding settings, refer to the
/// [checkoutBrandingUpsert](https://shopify.dev/api/admin-graphql/unstable/mutations/checkoutBrandingUpsert) mutation.
/// </summary>
public record CheckoutBranding : IGraphQLObject
{
    /// <summary>
    /// The customizations that apply to specific components or areas of the user interface.
    /// </summary>
    [JsonPropertyName("customizations")]
    public CheckoutBrandingCustomizations? customizations { get; set; } = null;

    /// <summary>
    /// The design system allows you to set values that represent specific attributes
    /// of your brand like color and font. These attributes are used throughout the user
    /// interface. This brings consistency and allows you to easily make broad design changes.
    /// </summary>
    [JsonPropertyName("designSystem")]
    public CheckoutBrandingDesignSystem? designSystem { get; set; } = null;
}