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
/// The input fields for customizing a base set of colors, from which every component pulls its colors.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingColorsInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingColorsInput>
{
    /// <summary>
    /// The main colors, used for the surface background, text, links, and more.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutAndAccountsConfigurationBrandingBaseColorRolesInput? @base { get; set; } = null;

    /// <summary>
    /// The colors of form controls, such as the [`TextField`](https://shopify.dev/docs/api/checkout-ui-extensions/latest/components/forms/textfield) and [`ChoiceList`](https://shopify.dev/docs/api/checkout-ui-extensions/latest/components/forms/choicelist) components.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutAndAccountsConfigurationBrandingControlColorRolesInput? control { get; set; } = null;

    /// <summary>
    /// The colors of the primary button. For example, the main payment, or **Pay now** button.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesInput? primaryButton { get; set; } = null;

    /// <summary>
    /// The colors of the secondary button, which is used for secondary actions. For example, **Buy again**.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesInput? secondaryButton { get; set; } = null;
}