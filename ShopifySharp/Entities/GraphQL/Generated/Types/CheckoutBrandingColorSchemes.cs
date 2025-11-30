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
/// The color schemes.
/// </summary>
public record CheckoutBrandingColorSchemes : IGraphQLObject
{
    /// <summary>
    /// The primary scheme. By default, it’s used for the main area of the interface.
    /// </summary>
    [JsonPropertyName("scheme1")]
    public CheckoutBrandingColorScheme? scheme1 { get; set; } = null;

    /// <summary>
    /// The secondary scheme. By default, it’s used for secondary areas, like Checkout’s Order Summary.
    /// </summary>
    [JsonPropertyName("scheme2")]
    public CheckoutBrandingColorScheme? scheme2 { get; set; } = null;

    /// <summary>
    /// An extra scheme available to customize more surfaces, components or specific states of the user interface.
    /// </summary>
    [JsonPropertyName("scheme3")]
    public CheckoutBrandingColorScheme? scheme3 { get; set; } = null;

    /// <summary>
    /// An extra scheme available to customize more surfaces, components or specific states of the user interface.
    /// </summary>
    [JsonPropertyName("scheme4")]
    public CheckoutBrandingColorScheme? scheme4 { get; set; } = null;
}