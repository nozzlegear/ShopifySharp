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
/// The order summary customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingOrderSummary : IGraphQLObject
{
    /// <summary>
    /// The background image of the order summary container.
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutAndAccountsConfigurationBrandingImageValue? backgroundImage { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The order summary container's divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingContainerDivider? divider { get; set; } = null;

    /// <summary>
    /// The order summary sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingOrderSummarySection? section { get; set; } = null;
}