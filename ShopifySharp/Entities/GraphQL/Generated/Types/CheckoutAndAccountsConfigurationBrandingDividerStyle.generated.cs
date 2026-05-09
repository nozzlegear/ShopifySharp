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
/// The customizations for the page, content, main, and order summary dividers.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingDividerStyle : IGraphQLObject
{
    /// <summary>
    /// The border style for the divider.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutAndAccountsConfigurationBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The border width for the divider.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutAndAccountsConfigurationBrandingBorderWidth? borderWidth { get; set; } = null;
}