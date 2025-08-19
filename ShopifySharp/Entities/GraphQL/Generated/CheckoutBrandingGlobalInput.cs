#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the global customizations.
/// </summary>
public record CheckoutBrandingGlobalInput : GraphQLInputObject<CheckoutBrandingGlobalInput>
{
    /// <summary>
    /// Select a global corner radius setting that overrides all other [corner radii](https://shopify.dev/docs/api/admin-graphql/latest/enums/CheckoutBrandingCornerRadius)
    /// customizations.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingGlobalCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The global typography customizations.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleGlobalInput? typography { get; set; } = null;
}