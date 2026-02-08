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
/// The input fields for a base set of color customizations that's applied to an area of Checkout, from which
/// every component pulls its colors.
/// </summary>
public record CheckoutBrandingColorSchemeInput : GraphQLInputObject<CheckoutBrandingColorSchemeInput>
{
    /// <summary>
    /// The main colors of a scheme. Used for the surface background, text, links, and more.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutBrandingColorRolesInput? @base { get; set; } = null;

    /// <summary>
    /// The colors of form controls, such as the [`TextField`](https://shopify.dev/docs/api/checkout-ui-extensions/latest/components/forms/textfield) and [`ChoiceList`](https://shopify.dev/docs/api/checkout-ui-extensions/latest/components/forms/choicelist) components.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutBrandingControlColorRolesInput? control { get; set; } = null;

    /// <summary>
    /// The colors of the primary button. For example, the main payment, or **Pay now** button.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutBrandingButtonColorRolesInput? primaryButton { get; set; } = null;

    /// <summary>
    /// The colors of the secondary button, which is used for secondary actions. For example, **Buy again**.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutBrandingButtonColorRolesInput? secondaryButton { get; set; } = null;
}