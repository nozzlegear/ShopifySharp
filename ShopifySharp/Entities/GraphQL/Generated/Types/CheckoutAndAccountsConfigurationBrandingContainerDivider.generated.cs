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
/// The container's divider customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingContainerDivider : IGraphQLObject
{
    /// <summary>
    /// The divider style.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutAndAccountsConfigurationBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The divider width.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutAndAccountsConfigurationBrandingBorderWidth? borderWidth { get; set; } = null;

    /// <summary>
    /// The divider visibility.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutAndAccountsConfigurationBrandingVisibility? visibility { get; set; } = null;
}