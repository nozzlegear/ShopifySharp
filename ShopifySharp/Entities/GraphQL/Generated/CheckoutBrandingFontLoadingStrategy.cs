#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The font loading strategy determines how a font face is displayed after it is loaded or failed to load.
/// For more information: https://developer.mozilla.org/en-US/docs/Web/CSS/@font-face/font-display.
/// </summary>
public enum CheckoutBrandingFontLoadingStrategy
{
    AUTO,
    BLOCK,
    SWAP,
    FALLBACK,
    OPTIONAL,
}