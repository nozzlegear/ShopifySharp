#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the color schemes.
/// </summary>
public record CheckoutBrandingColorSchemesInput : GraphQLInputObject<CheckoutBrandingColorSchemesInput>
{
    /// <summary>
    /// The primary scheme. By default, it’s used for the main area of the interface.
    /// </summary>
    [JsonPropertyName("scheme1")]
    public CheckoutBrandingColorSchemeInput? scheme1 { get; set; } = null;

    /// <summary>
    /// The secondary scheme. By default, it’s used for secondary areas, like Checkout’s Order Summary.
    /// </summary>
    [JsonPropertyName("scheme2")]
    public CheckoutBrandingColorSchemeInput? scheme2 { get; set; } = null;

    /// <summary>
    /// An extra scheme available to customize more surfaces, components or specific states of the user interface.
    /// </summary>
    [JsonPropertyName("scheme3")]
    public CheckoutBrandingColorSchemeInput? scheme3 { get; set; } = null;

    /// <summary>
    /// An extra scheme available to customize more surfaces, components or specific states of the user interface.
    /// </summary>
    [JsonPropertyName("scheme4")]
    public CheckoutBrandingColorSchemeInput? scheme4 { get; set; } = null;
}