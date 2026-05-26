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
/// The shared customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingShared : IGraphQLObject
{
    /// <summary>
    /// The shared color customizations for semantic and functional colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingSharedColors? colors { get; set; } = null;

    /// <summary>
    /// The shared corner radius setting that overrides all other [corner radius](https://shopify.dev/docs/api/admin-graphql/latest/enums/CheckoutAndAccountsConfigurationBrandingCornerRadius)
    /// customizations.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingSharedCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The shared typography customizations.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingSharedTypographyStyle? typography { get; set; } = null;
}