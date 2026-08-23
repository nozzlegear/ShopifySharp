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
/// The base component customizations that apply to all surfaces.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingComponents : IGraphQLObject
{
    /// <summary>
    /// The checkboxes.
    /// </summary>
    [JsonPropertyName("checkbox")]
    public CheckoutAndAccountsConfigurationBrandingCheckbox? checkbox { get; set; } = null;

    /// <summary>
    /// The choice list.
    /// </summary>
    [JsonPropertyName("choiceList")]
    public CheckoutAndAccountsConfigurationBrandingChoiceList? choiceList { get; set; } = null;

    /// <summary>
    /// The form controls.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutAndAccountsConfigurationBrandingControl? control { get; set; } = null;

    /// <summary>
    /// The customizations for the page, content, main, and order summary dividers.
    /// For example, by setting the borderStyle to `DOTTED`, you can make these
    /// dividers render as dotted lines.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingDividerStyle? divider { get; set; } = null;

    /// <summary>
    /// The favicon.
    /// </summary>
    [JsonPropertyName("favicon")]
    public CheckoutAndAccountsConfigurationBrandingImageValue? favicon { get; set; } = null;

    /// <summary>
    /// The footer.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingFooter? footer { get; set; } = null;

    /// <summary>
    /// The header.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingHeader? header { get; set; } = null;

    /// <summary>
    /// The Heading Level 1.
    /// </summary>
    [JsonPropertyName("headingLevel1")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevel? headingLevel1 { get; set; } = null;

    /// <summary>
    /// The Heading Level 2.
    /// </summary>
    [JsonPropertyName("headingLevel2")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevel? headingLevel2 { get; set; } = null;

    /// <summary>
    /// The Heading Level 3.
    /// </summary>
    [JsonPropertyName("headingLevel3")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevel? headingLevel3 { get; set; } = null;

    /// <summary>
    /// The main area.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingMain? main { get; set; } = null;

    /// <summary>
    /// The merchandise thumbnails.
    /// </summary>
    [JsonPropertyName("merchandiseThumbnail")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail? merchandiseThumbnail { get; set; } = null;

    /// <summary>
    /// The primary buttons.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutAndAccountsConfigurationBrandingButton? primaryButton { get; set; } = null;

    /// <summary>
    /// The secondary buttons.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutAndAccountsConfigurationBrandingButton? secondaryButton { get; set; } = null;

    /// <summary>
    /// The selects.
    /// </summary>
    [JsonPropertyName("select")]
    public CheckoutAndAccountsConfigurationBrandingSelect? @select { get; set; } = null;

    /// <summary>
    /// The shared settings.
    /// </summary>
    [JsonPropertyName("shared")]
    public CheckoutAndAccountsConfigurationBrandingShared? shared { get; set; } = null;

    /// <summary>
    /// The text fields.
    /// </summary>
    [JsonPropertyName("textField")]
    public CheckoutAndAccountsConfigurationBrandingTextField? textField { get; set; } = null;
}