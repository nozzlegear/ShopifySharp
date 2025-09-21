#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for footer content customizations.
/// </summary>
public record CheckoutBrandingFooterContentInput : GraphQLInputObject<CheckoutBrandingFooterContentInput>
{
    /// <summary>
    /// The visibility settings for footer content.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}