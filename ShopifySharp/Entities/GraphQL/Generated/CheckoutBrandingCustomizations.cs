#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The customizations that apply to specific components or areas of the user interface.
/// </summary>
public record CheckoutBrandingCustomizations : IGraphQLObject
{
    /// <summary>
    /// The customizations for the breadcrumbs that represent a buyer's journey to the checkout.
    /// </summary>
    [JsonPropertyName("buyerJourney")]
    public CheckoutBrandingBuyerJourney? buyerJourney { get; set; } = null;

    /// <summary>
    /// The checkout cart link customizations. For example, by setting the visibility
    /// field to `HIDDEN`, you can hide the cart icon in the header for one-page
    /// checkout, and the cart link in breadcrumbs in three-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutBrandingCartLink? cartLink { get; set; } = null;

    /// <summary>
    /// The checkboxes customizations.
    /// </summary>
    [JsonPropertyName("checkbox")]
    public CheckoutBrandingCheckbox? checkbox { get; set; } = null;

    /// <summary>
    /// The choice list customizations.
    /// </summary>
    [JsonPropertyName("choiceList")]
    public CheckoutBrandingChoiceList? choiceList { get; set; } = null;

    /// <summary>
    /// The content container customizations.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutBrandingContent? content { get; set; } = null;

    /// <summary>
    /// The form controls customizations.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutBrandingControl? control { get; set; } = null;

    /// <summary>
    /// The customizations for the page, content, main, and order summary dividers.
    /// For example, by setting the borderStyle to `DOTTED`, you can make these
    /// dividers render as dotted lines.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingDividerStyle? divider { get; set; } = null;

    /// <summary>
    /// The express checkout customizations.
    /// </summary>
    [JsonPropertyName("expressCheckout")]
    public CheckoutBrandingExpressCheckout? expressCheckout { get; set; } = null;

    /// <summary>
    /// The favicon image.
    /// </summary>
    [JsonPropertyName("favicon")]
    public CheckoutBrandingImage? favicon { get; set; } = null;

    /// <summary>
    /// The footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutBrandingFooter? footer { get; set; } = null;

    /// <summary>
    /// The global customizations.
    /// </summary>
    [JsonPropertyName("global")]
    public CheckoutBrandingGlobal? @global { get; set; } = null;

    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutBrandingHeader? header { get; set; } = null;

    /// <summary>
    /// The Heading Level 1 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel1")]
    public CheckoutBrandingHeadingLevel? headingLevel1 { get; set; } = null;

    /// <summary>
    /// The Heading Level 2 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel2")]
    public CheckoutBrandingHeadingLevel? headingLevel2 { get; set; } = null;

    /// <summary>
    /// The Heading Level 3 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel3")]
    public CheckoutBrandingHeadingLevel? headingLevel3 { get; set; } = null;

    /// <summary>
    /// The main area customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutBrandingMain? main { get; set; } = null;

    /// <summary>
    /// The merchandise thumbnails customizations.
    /// </summary>
    [JsonPropertyName("merchandiseThumbnail")]
    public CheckoutBrandingMerchandiseThumbnail? merchandiseThumbnail { get; set; } = null;

    /// <summary>
    /// The order summary customizations.
    /// </summary>
    [JsonPropertyName("orderSummary")]
    public CheckoutBrandingOrderSummary? orderSummary { get; set; } = null;

    /// <summary>
    /// The primary buttons customizations.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutBrandingButton? primaryButton { get; set; } = null;

    /// <summary>
    /// The secondary buttons customizations.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutBrandingButton? secondaryButton { get; set; } = null;

    /// <summary>
    /// The selects customizations.
    /// </summary>
    [JsonPropertyName("select")]
    public CheckoutBrandingSelect? @select { get; set; } = null;

    /// <summary>
    /// The text fields customizations.
    /// </summary>
    [JsonPropertyName("textField")]
    public CheckoutBrandingTextField? textField { get; set; } = null;
}