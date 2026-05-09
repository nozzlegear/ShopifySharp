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
/// The input fields for customizing the order summary container.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingOrderSummaryInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingOrderSummaryInput>
{
    /// <summary>
    /// The background image of the order summary container (must not be of SVG format).
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutAndAccountsConfigurationBrandingImageInput? backgroundImage { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// Divider style and visibility on the order summary container.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingContainerDividerInput? divider { get; set; } = null;

    /// <summary>
    /// The customizations for the order summary sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionInput? section { get; set; } = null;
}