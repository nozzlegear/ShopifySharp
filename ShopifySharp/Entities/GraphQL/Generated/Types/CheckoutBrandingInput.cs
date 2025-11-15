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
/// The input fields used to upsert the checkout branding settings.
/// </summary>
public record CheckoutBrandingInput : GraphQLInputObject<CheckoutBrandingInput>
{
    /// <summary>
    /// The customizations that apply to specific components or areas of the user interface.
    /// </summary>
    [JsonPropertyName("customizations")]
    public CheckoutBrandingCustomizationsInput? customizations { get; set; } = null;

    /// <summary>
    /// The design system allows you to set values that represent specific attributes
    /// of your brand like color and font. These attributes are used throughout the user
    /// interface. This brings consistency and allows you to easily make broad design changes.
    /// </summary>
    [JsonPropertyName("designSystem")]
    public CheckoutBrandingDesignSystemInput? designSystem { get; set; } = null;
}