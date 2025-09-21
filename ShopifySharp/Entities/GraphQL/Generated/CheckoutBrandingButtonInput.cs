#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update the buttons customizations.
/// </summary>
public record CheckoutBrandingButtonInput : GraphQLInputObject<CheckoutBrandingButtonInput>
{
    /// <summary>
    /// The background style used for buttons.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutBrandingBackgroundStyle? background { get; set; } = null;

    /// <summary>
    /// The block padding used for buttons.
    /// </summary>
    [JsonPropertyName("blockPadding")]
    public CheckoutBrandingSpacing? blockPadding { get; set; } = null;

    /// <summary>
    /// The border used for buttons.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The corner radius used for buttons.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The inline padding used for buttons.
    /// </summary>
    [JsonPropertyName("inlinePadding")]
    public CheckoutBrandingSpacing? inlinePadding { get; set; } = null;

    /// <summary>
    /// The typography style used for buttons.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleInput? typography { get; set; } = null;
}