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
/// The input fields for customizing the sign-in main container.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInMainInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSignInMainInput>
{
    /// <summary>
    /// The background image of the main container.
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutAndAccountsConfigurationBrandingImageInput? backgroundImage { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The customizations for the main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingMainSectionInput? section { get; set; } = null;
}