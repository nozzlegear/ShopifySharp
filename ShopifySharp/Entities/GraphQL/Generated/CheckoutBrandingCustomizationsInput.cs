#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the components customizations.
/// </summary>
public record CheckoutBrandingCustomizationsInput : GraphQLInputObject<CheckoutBrandingCustomizationsInput>
{
    /// <summary>
    /// The customizations for the breadcrumbs that represent a buyer's journey to the checkout.
    /// </summary>
    [JsonPropertyName("buyerJourney")]
    public CheckoutBrandingBuyerJourneyInput? buyerJourney { get; set; } = null;

    /// <summary>
    /// The input for checkout cart link customizations. For example, by setting the
    /// visibility field to `HIDDEN`, you can hide the cart icon in the header for
    /// one-page checkout, and the cart link in breadcrumbs in three-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutBrandingCartLinkInput? cartLink { get; set; } = null;

    /// <summary>
    /// The checkboxes customizations.
    /// </summary>
    [JsonPropertyName("checkbox")]
    public CheckoutBrandingCheckboxInput? checkbox { get; set; } = null;

    /// <summary>
    /// The choice list customizations.
    /// </summary>
    [JsonPropertyName("choiceList")]
    public CheckoutBrandingChoiceListInput? choiceList { get; set; } = null;

    /// <summary>
    /// The content container customizations.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutBrandingContentInput? content { get; set; } = null;

    /// <summary>
    /// The form controls customizations.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutBrandingControlInput? control { get; set; } = null;

    /// <summary>
    /// The input for the page, content, main, and order summary dividers
    /// customizations. For example, by setting the borderStyle to `DOTTED`, you can
    /// make these dividers render as dotted lines.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingDividerStyleInput? divider { get; set; } = null;

    /// <summary>
    /// The express checkout customizations.
    /// </summary>
    [JsonPropertyName("expressCheckout")]
    public CheckoutBrandingExpressCheckoutInput? expressCheckout { get; set; } = null;

    /// <summary>
    /// The favicon image (must be of PNG format).
    /// </summary>
    [JsonPropertyName("favicon")]
    public CheckoutBrandingImageInput? favicon { get; set; } = null;

    /// <summary>
    /// The footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutBrandingFooterInput? footer { get; set; } = null;

    /// <summary>
    /// The global customizations.
    /// </summary>
    [JsonPropertyName("global")]
    public CheckoutBrandingGlobalInput? @global { get; set; } = null;

    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutBrandingHeaderInput? header { get; set; } = null;

    /// <summary>
    /// The Heading Level 1 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel1")]
    public CheckoutBrandingHeadingLevelInput? headingLevel1 { get; set; } = null;

    /// <summary>
    /// The Heading Level 2 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel2")]
    public CheckoutBrandingHeadingLevelInput? headingLevel2 { get; set; } = null;

    /// <summary>
    /// The Heading Level 3 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel3")]
    public CheckoutBrandingHeadingLevelInput? headingLevel3 { get; set; } = null;

    /// <summary>
    /// The main area customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutBrandingMainInput? main { get; set; } = null;

    /// <summary>
    /// The merchandise thumbnails customizations.
    /// </summary>
    [JsonPropertyName("merchandiseThumbnail")]
    public CheckoutBrandingMerchandiseThumbnailInput? merchandiseThumbnail { get; set; } = null;

    /// <summary>
    /// The order summary customizations.
    /// </summary>
    [JsonPropertyName("orderSummary")]
    public CheckoutBrandingOrderSummaryInput? orderSummary { get; set; } = null;

    /// <summary>
    /// The primary buttons customizations.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutBrandingButtonInput? primaryButton { get; set; } = null;

    /// <summary>
    /// The secondary buttons customizations.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutBrandingButtonInput? secondaryButton { get; set; } = null;

    /// <summary>
    /// The selects customizations.
    /// </summary>
    [JsonPropertyName("select")]
    public CheckoutBrandingSelectInput? @select { get; set; } = null;

    /// <summary>
    /// The text fields customizations.
    /// </summary>
    [JsonPropertyName("textField")]
    public CheckoutBrandingTextFieldInput? textField { get; set; } = null;
}