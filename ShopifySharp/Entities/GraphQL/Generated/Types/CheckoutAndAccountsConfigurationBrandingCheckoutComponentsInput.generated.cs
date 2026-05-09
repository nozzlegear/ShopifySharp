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
/// The input fields for customizing the Checkout components.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutComponentsInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCheckoutComponentsInput>
{
    /// <summary>
    /// The breadcrumbs that represent a buyer's journey to the checkout.
    /// </summary>
    [JsonPropertyName("buyerJourney")]
    public CheckoutAndAccountsConfigurationBrandingBuyerJourneyInput? buyerJourney { get; set; } = null;

    /// <summary>
    /// The input for checkout cart link customizations. For example, by setting the
    /// visibility field to `HIDDEN`, you can hide the cart icon in the header for
    /// one-page checkout, and the cart link in breadcrumbs in three-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutAndAccountsConfigurationBrandingCartLinkInput? cartLink { get; set; } = null;

    /// <summary>
    /// The content container.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutAndAccountsConfigurationBrandingContentInput? content { get; set; } = null;

    /// <summary>
    /// The express checkout.
    /// </summary>
    [JsonPropertyName("expressCheckout")]
    public CheckoutAndAccountsConfigurationBrandingExpressCheckoutInput? expressCheckout { get; set; } = null;

    /// <summary>
    /// The footer.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutFooterInput? footer { get; set; } = null;

    /// <summary>
    /// The header.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderInput? header { get; set; } = null;

    /// <summary>
    /// The main area.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingMainInput? main { get; set; } = null;

    /// <summary>
    /// The order summary.
    /// </summary>
    [JsonPropertyName("orderSummary")]
    public CheckoutAndAccountsConfigurationBrandingOrderSummaryInput? orderSummary { get; set; } = null;
}