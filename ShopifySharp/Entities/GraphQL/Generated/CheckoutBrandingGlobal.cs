#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The global customizations.
/// </summary>
public record CheckoutBrandingGlobal : IGraphQLObject
{
    /// <summary>
    /// The global corner radius setting that overrides all other [corner radius](https://shopify.dev/docs/api/admin-graphql/latest/enums/CheckoutBrandingCornerRadius)
    /// customizations.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingGlobalCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The global typography customizations.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleGlobal? typography { get; set; } = null;
}