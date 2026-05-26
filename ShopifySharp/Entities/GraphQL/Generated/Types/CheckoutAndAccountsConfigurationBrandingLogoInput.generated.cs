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
/// The input fields for customizing the logo.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingLogoInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingLogoInput>
{
    /// <summary>
    /// The logo image.
    /// </summary>
    [JsonPropertyName("image")]
    public CheckoutAndAccountsConfigurationBrandingImageInput? image { get; set; } = null;

    /// <summary>
    /// The maximum width of the logo.
    /// </summary>
    [JsonPropertyName("maxWidth")]
    public int? maxWidth { get; set; } = null;

    /// <summary>
    /// The visibility of the logo.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutAndAccountsConfigurationBrandingVisibility? visibility { get; set; } = null;
}