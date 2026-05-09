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
/// The checkout-specific component customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutComponents : IGraphQLObject
{
    /// <summary>
    /// The customizations for the breadcrumbs that represent a buyer's journey to the checkout.
    /// </summary>
    [JsonPropertyName("buyerJourney")]
    public CheckoutAndAccountsConfigurationBrandingBuyerJourney? buyerJourney { get; set; } = null;

    /// <summary>
    /// The checkout cart link customizations. For example, by setting the visibility
    /// field to `HIDDEN`, you can hide the cart icon in the header for one-page
    /// checkout, and the cart link in breadcrumbs in three-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutAndAccountsConfigurationBrandingCartLink? cartLink { get; set; } = null;

    /// <summary>
    /// The content container customizations.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutAndAccountsConfigurationBrandingContent? content { get; set; } = null;

    /// <summary>
    /// The express checkout customizations.
    /// </summary>
    [JsonPropertyName("expressCheckout")]
    public CheckoutAndAccountsConfigurationBrandingExpressCheckout? expressCheckout { get; set; } = null;

    /// <summary>
    /// The checkout footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutFooter? footer { get; set; } = null;

    /// <summary>
    /// The checkout header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutHeader? header { get; set; } = null;

    /// <summary>
    /// The main checkout customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingMain? main { get; set; } = null;

    /// <summary>
    /// The order summary customizations.
    /// </summary>
    [JsonPropertyName("orderSummary")]
    public CheckoutAndAccountsConfigurationBrandingOrderSummary? orderSummary { get; set; } = null;
}