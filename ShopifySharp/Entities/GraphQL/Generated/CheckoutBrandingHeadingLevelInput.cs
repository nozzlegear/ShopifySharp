#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for heading level customizations.
/// </summary>
public record CheckoutBrandingHeadingLevelInput : GraphQLInputObject<CheckoutBrandingHeadingLevelInput>
{
    /// <summary>
    /// The typography customizations used for headings.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleInput? typography { get; set; } = null;
}