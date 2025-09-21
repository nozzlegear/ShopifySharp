#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The container's divider customizations.
/// </summary>
public record CheckoutBrandingContainerDivider : IGraphQLObject
{
    /// <summary>
    /// The divider style.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The divider width.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutBrandingBorderWidth? borderWidth { get; set; } = null;

    /// <summary>
    /// The divider visibility.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}