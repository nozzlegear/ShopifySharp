#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The content container customizations.
/// </summary>
public record CheckoutBrandingContent : IGraphQLObject
{
    /// <summary>
    /// The content container's divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDivider? divider { get; set; } = null;
}