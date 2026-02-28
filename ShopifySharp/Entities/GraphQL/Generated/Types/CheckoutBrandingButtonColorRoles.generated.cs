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
/// Defines the color palette specifically for button elements within checkout
/// branding, including hover states. These color roles ensure buttons maintain
/// proper contrast and visual hierarchy throughout the checkout experience.
/// For example, a sports brand might configure bright accent colors for primary
/// action buttons, with darker hover states and contrasting text colors that
/// maintain accessibility standards.
/// Use the `ButtonColorRoles` object to:
/// - Define button color schemes for different states
/// - Ensure proper contrast for accessibility compliance
/// - Coordinate button colors with overall brand palette
/// Button color roles include background, border, text, icon, accent (for focused
/// states), and decorative elements, plus specific hover state colors that provide
/// clear interactive feedback to customers.
/// </summary>
public record CheckoutBrandingButtonColorRoles : IGraphQLObject
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
    public CheckoutBrandingColorRoles? hover { get; set; } = null;

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