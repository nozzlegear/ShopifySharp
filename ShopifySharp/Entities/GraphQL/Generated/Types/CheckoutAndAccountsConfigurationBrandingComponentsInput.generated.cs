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
/// The input fields for customizing the components.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingComponentsInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingComponentsInput>
{
    /// <summary>
    /// The checkboxes customizations.
    /// </summary>
    [JsonPropertyName("checkbox")]
    public CheckoutAndAccountsConfigurationBrandingCheckboxInput? checkbox { get; set; } = null;

    /// <summary>
    /// The choice list customizations.
    /// </summary>
    [JsonPropertyName("choiceList")]
    public CheckoutAndAccountsConfigurationBrandingChoiceListInput? choiceList { get; set; } = null;

    /// <summary>
    /// The form controls customizations.
    /// </summary>
    [JsonPropertyName("control")]
    public CheckoutAndAccountsConfigurationBrandingControlInput? control { get; set; } = null;

    /// <summary>
    /// The divider customizations.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingDividerStyleInput? divider { get; set; } = null;

    /// <summary>
    /// The favicon.
    /// </summary>
    [JsonPropertyName("favicon")]
    public CheckoutAndAccountsConfigurationBrandingImageInput? favicon { get; set; } = null;

    /// <summary>
    /// The footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingFooterInput? footer { get; set; } = null;

    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingHeaderInput? header { get; set; } = null;

    /// <summary>
    /// The Heading Level 1 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel1")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevelInput? headingLevel1 { get; set; } = null;

    /// <summary>
    /// The Heading Level 2 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel2")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevelInput? headingLevel2 { get; set; } = null;

    /// <summary>
    /// The Heading Level 3 customizations.
    /// </summary>
    [JsonPropertyName("headingLevel3")]
    public CheckoutAndAccountsConfigurationBrandingHeadingLevelInput? headingLevel3 { get; set; } = null;

    /// <summary>
    /// The main area customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingMainInput? main { get; set; } = null;

    /// <summary>
    /// The merchandise thumbnails customizations.
    /// </summary>
    [JsonPropertyName("merchandiseThumbnail")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailInput? merchandiseThumbnail { get; set; } = null;

    /// <summary>
    /// The primary buttons customizations.
    /// </summary>
    [JsonPropertyName("primaryButton")]
    public CheckoutAndAccountsConfigurationBrandingButtonInput? primaryButton { get; set; } = null;

    /// <summary>
    /// The secondary buttons customizations.
    /// </summary>
    [JsonPropertyName("secondaryButton")]
    public CheckoutAndAccountsConfigurationBrandingButtonInput? secondaryButton { get; set; } = null;

    /// <summary>
    /// The selects customizations.
    /// </summary>
    [JsonPropertyName("select")]
    public CheckoutAndAccountsConfigurationBrandingSelectInput? @select { get; set; } = null;

    /// <summary>
    /// The shared customizations.
    /// </summary>
    [JsonPropertyName("shared")]
    public CheckoutAndAccountsConfigurationBrandingSharedInput? shared { get; set; } = null;

    /// <summary>
    /// The text fields customizations.
    /// </summary>
    [JsonPropertyName("textField")]
    public CheckoutAndAccountsConfigurationBrandingTextFieldInput? textField { get; set; } = null;
}