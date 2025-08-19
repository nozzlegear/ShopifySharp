#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Shopify application.
/// </summary>
public record App : IGraphQLObject, INode
{
    /// <summary>
    /// A unique application API identifier.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? apiKey { get; set; } = null;

    /// <summary>
    /// App store page URL of the app.
    /// </summary>
    [JsonPropertyName("appStoreAppUrl")]
    public string? appStoreAppUrl { get; set; } = null;

    /// <summary>
    /// App store page URL of the developer who created the app.
    /// </summary>
    [JsonPropertyName("appStoreDeveloperUrl")]
    public string? appStoreDeveloperUrl { get; set; } = null;

    /// <summary>
    /// All requestable access scopes available to the app.
    /// </summary>
    [JsonPropertyName("availableAccessScopes")]
    public ICollection<AccessScope>? availableAccessScopes { get; set; } = null;

    /// <summary>
    /// Banner image for the app.
    /// </summary>
    [JsonPropertyName("banner")]
    public Image? banner { get; set; } = null;

    /// <summary>
    /// Description of the app.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The name of the app developer.
    /// </summary>
    [JsonPropertyName("developerName")]
    public string? developerName { get; set; } = null;

    /// <summary>
    /// The type of app developer.
    /// </summary>
    [JsonPropertyName("developerType")]
    public AppDeveloperType? developerType { get; set; } = null;

    /// <summary>
    /// Website of the developer who created the app.
    /// </summary>
    [JsonPropertyName("developerUrl")]
    [Obsolete("Use `appStoreDeveloperUrl` instead.")]
    public string? developerUrl { get; set; } = null;

    /// <summary>
    /// Whether the app uses the Embedded App SDK.
    /// </summary>
    [JsonPropertyName("embedded")]
    public bool? embedded { get; set; } = null;

    /// <summary>
    /// Requirements that must be met before the app can be installed.
    /// </summary>
    [JsonPropertyName("failedRequirements")]
    public ICollection<FailedRequirement>? failedRequirements { get; set; } = null;

    /// <summary>
    /// A list of app features that are shown in the Shopify App Store listing.
    /// </summary>
    [JsonPropertyName("features")]
    public ICollection<string>? features { get; set; } = null;

    /// <summary>
    /// Feedback from this app about the store.
    /// </summary>
    [JsonPropertyName("feedback")]
    public AppFeedback? feedback { get; set; } = null;

    /// <summary>
    /// Handle of the app.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Icon that represents the app.
    /// </summary>
    [JsonPropertyName("icon")]
    public Image? icon { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Corresponding AppInstallation for this shop and App.
    /// Returns null if the App is not installed.
    /// </summary>
    [JsonPropertyName("installation")]
    public AppInstallation? installation { get; set; } = null;

    /// <summary>
    /// Webpage where you can install the app.
    /// </summary>
    [JsonPropertyName("installUrl")]
    public string? installUrl { get; set; } = null;

    /// <summary>
    /// Whether the app is the [post purchase](https://shopify.dev/apps/checkout/post-purchase) app in use.
    /// </summary>
    [JsonPropertyName("isPostPurchaseAppInUse")]
    public bool? isPostPurchaseAppInUse { get; set; } = null;

    /// <summary>
    /// Webpage that the app starts in.
    /// </summary>
    [JsonPropertyName("launchUrl")]
    [Obsolete("Use AppInstallation.launchUrl instead")]
    public string? launchUrl { get; set; } = null;

    /// <summary>
    /// Menu items for the app, which also appear as submenu items in left navigation sidebar in the Shopify admin.
    /// </summary>
    [JsonPropertyName("navigationItems")]
    [Obsolete("Use AppInstallation.navigationItems instead")]
    public ICollection<NavigationItem>? navigationItems { get; set; } = null;

    /// <summary>
    /// The optional scopes requested by the app. Lists the optional access scopes the
    /// app has declared in its configuration. These scopes are optionally requested
    /// by the app after installation.
    /// </summary>
    [JsonPropertyName("optionalAccessScopes")]
    public ICollection<AccessScope>? optionalAccessScopes { get; set; } = null;

    /// <summary>
    /// Whether the app was previously installed on the current shop.
    /// </summary>
    [JsonPropertyName("previouslyInstalled")]
    public bool? previouslyInstalled { get; set; } = null;

    /// <summary>
    /// Detailed information about the app pricing.
    /// </summary>
    [JsonPropertyName("pricingDetails")]
    public string? pricingDetails { get; set; } = null;

    /// <summary>
    /// Summary of the app pricing details.
    /// </summary>
    [JsonPropertyName("pricingDetailsSummary")]
    public string? pricingDetailsSummary { get; set; } = null;

    /// <summary>
    /// Link to app privacy policy.
    /// </summary>
    [JsonPropertyName("privacyPolicyUrl")]
    public string? privacyPolicyUrl { get; set; } = null;

    /// <summary>
    /// The public category for the app.
    /// </summary>
    [JsonPropertyName("publicCategory")]
    public AppPublicCategory? publicCategory { get; set; } = null;

    /// <summary>
    /// Whether the app is published to the Shopify App Store.
    /// </summary>
    [JsonPropertyName("published")]
    public bool? published { get; set; } = null;

    /// <summary>
    /// The access scopes requested by the app. Lists the access scopes the app has
    /// declared in its configuration. Merchant must grant approval to these scopes
    /// for the app to be installed.
    /// </summary>
    [JsonPropertyName("requestedAccessScopes")]
    public ICollection<AccessScope>? requestedAccessScopes { get; set; } = null;

    /// <summary>
    /// Screenshots of the app.
    /// </summary>
    [JsonPropertyName("screenshots")]
    public ICollection<Image>? screenshots { get; set; } = null;

    /// <summary>
    /// Whether the app was developed by Shopify.
    /// </summary>
    [JsonPropertyName("shopifyDeveloped")]
    public bool? shopifyDeveloped { get; set; } = null;

    /// <summary>
    /// Name of the app.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// Message that appears when the app is uninstalled. For example:
    /// By removing this app, you will no longer be able to publish products to
    /// MySocialSite or view this app in your Shopify admin. You can re-enable this
    /// channel at any time.
    /// </summary>
    [JsonPropertyName("uninstallMessage")]
    public string? uninstallMessage { get; set; } = null;

    /// <summary>
    /// Webpage where you can uninstall the app.
    /// </summary>
    [JsonPropertyName("uninstallUrl")]
    [Obsolete("Use AppInstallation.uninstallUrl instead")]
    public string? uninstallUrl { get; set; } = null;

    /// <summary>
    /// The webhook API version for the app.
    /// </summary>
    [JsonPropertyName("webhookApiVersion")]
    public string? webhookApiVersion { get; set; } = null;
}