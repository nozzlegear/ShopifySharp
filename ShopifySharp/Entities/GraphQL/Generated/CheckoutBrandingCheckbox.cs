#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The checkboxes customizations.
/// </summary>
public record CheckoutBrandingCheckbox : IGraphQLObject
{
    /// <summary>
    /// The corner radius used for checkboxes.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;
}