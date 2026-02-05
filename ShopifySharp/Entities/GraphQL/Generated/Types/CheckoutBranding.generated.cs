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
/// Creates a unified visual identity for your checkout that keeps customers engaged
/// and reinforces your brand throughout the purchase process. This comprehensive
/// branding system lets you control every visual aspect of checkout, from colors
/// and fonts to layouts and imagery, so your checkout feels like a natural
/// extension of your store.
/// For example, a luxury fashion retailer can configure their checkout with custom
/// color palettes, premium typography, rounded corners for a softer feel, and
/// branded imagery that matches their main website aesthetic.
/// Use the `Branding` object to:
/// - Configure comprehensive checkout visual identity
/// - Coordinate color schemes across all checkout elements
/// - Apply consistent typography and spacing standards
/// - Manage background imagery and layout customizations
/// - Control visibility of various checkout components
/// The branding configuration includes design system foundations like color roles,
/// typography scales, and spacing units, plus specific customizations for sections,
/// dividers, and interactive elements. This allows merchants to create cohesive
/// checkout experiences that reinforce their brand identity while maintaining
/// usability standards.
/// Different color schemes can be defined for various contexts, ensuring optimal
/// contrast and accessibility across different checkout states and customer preferences.
/// </summary>
public record CheckoutBranding : IGraphQLObject
{
    /// <summary>
    /// The customizations that apply to specific components or areas of the user interface.
    /// </summary>
    [JsonPropertyName("customizations")]
    public CheckoutBrandingCustomizations? customizations { get; set; } = null;

    /// <summary>
    /// The design system allows you to set values that represent specific attributes
    /// of your brand like color and font. These attributes are used throughout the user
    /// interface. This brings consistency and allows you to easily make broad design changes.
    /// </summary>
    [JsonPropertyName("designSystem")]
    public CheckoutBrandingDesignSystem? designSystem { get; set; } = null;
}