#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to set colors for buttons.
/// </summary>
public record CheckoutBrandingButtonColorRolesInput : GraphQLInputObject<CheckoutBrandingButtonColorRolesInput>
{
    /// <summary>
    /// The color of accented objects (links and focused state).
    /// </summary>
    [JsonPropertyName("accent")]
    public string? accent { get; set; } = null;

    /// <summary>
    /// The color of the background.
    /// </summary>
    [JsonPropertyName("background")]
    public string? background { get; set; } = null;

    /// <summary>
    /// The color of borders.
    /// </summary>
    [JsonPropertyName("border")]
    public string? border { get; set; } = null;

    /// <summary>
    /// The decorative color for highlighting specific parts of the user interface.
    /// </summary>
    [JsonPropertyName("decorative")]
    public string? decorative { get; set; } = null;

    /// <summary>
    /// The colors of the button on hover.
    /// </summary>
    [JsonPropertyName("hover")]
    public CheckoutBrandingColorRolesInput? hover { get; set; } = null;

    /// <summary>
    /// The color of icons.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? icon { get; set; } = null;

    /// <summary>
    /// The color of text.
    /// </summary>
    [JsonPropertyName("text")]
    public string? text { get; set; } = null;
}