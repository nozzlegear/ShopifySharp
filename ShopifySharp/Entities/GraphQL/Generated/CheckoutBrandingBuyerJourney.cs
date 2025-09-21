#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The customizations for the breadcrumbs that represent a buyer's journey to the checkout.
/// </summary>
public record CheckoutBrandingBuyerJourney : IGraphQLObject
{
    /// <summary>
    /// An option to display or hide the breadcrumbs that represent the buyer's journey on 3-page checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}