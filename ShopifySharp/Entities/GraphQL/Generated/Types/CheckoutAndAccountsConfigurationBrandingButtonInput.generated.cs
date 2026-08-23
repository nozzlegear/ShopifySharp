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
/// The input fields for customizing the buttons.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingButtonInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingButtonInput>
{
    /// <summary>
    /// The block padding.
    /// </summary>
    [JsonPropertyName("blockPadding")]
    public CheckoutAndAccountsConfigurationBrandingSpacing? blockPadding { get; set; } = null;

    /// <summary>
    /// The border.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutAndAccountsConfigurationBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The corner radius.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The inline padding.
    /// </summary>
    [JsonPropertyName("inlinePadding")]
    public CheckoutAndAccountsConfigurationBrandingSpacing? inlinePadding { get; set; } = null;

    /// <summary>
    /// The typography style.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingTypographyStyleInput? typography { get; set; } = null;
}