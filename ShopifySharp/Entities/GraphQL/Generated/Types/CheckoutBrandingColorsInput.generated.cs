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
/// The input fields used to update the color settings for global colors and color schemes.
/// </summary>
public record CheckoutBrandingColorsInput : GraphQLInputObject<CheckoutBrandingColorsInput>
{
    /// <summary>
    /// The input to update global colors for customizing the overall look and feel of the user interface.
    /// </summary>
    [JsonPropertyName("global")]
    public CheckoutBrandingColorGlobalInput? @global { get; set; } = null;

    /// <summary>
    /// The input to define color schemes which apply to different areas of the user interface.
    /// </summary>
    [JsonPropertyName("schemes")]
    public CheckoutBrandingColorSchemesInput? schemes { get; set; } = null;
}