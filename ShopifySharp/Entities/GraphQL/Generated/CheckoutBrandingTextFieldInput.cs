#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the text fields customizations.
/// </summary>
public record CheckoutBrandingTextFieldInput : GraphQLInputObject<CheckoutBrandingTextFieldInput>
{
    /// <summary>
    /// The border used for text fields.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography customizations used for text fields.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleInput? typography { get; set; } = null;
}