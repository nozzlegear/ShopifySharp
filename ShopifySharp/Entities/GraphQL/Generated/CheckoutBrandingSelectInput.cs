#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the selects customizations.
/// </summary>
public record CheckoutBrandingSelectInput : GraphQLInputObject<CheckoutBrandingSelectInput>
{
    /// <summary>
    /// The border used for selects.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography customizations used for selects.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleInput? typography { get; set; } = null;
}