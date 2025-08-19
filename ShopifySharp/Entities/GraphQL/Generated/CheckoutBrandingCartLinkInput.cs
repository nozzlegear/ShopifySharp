#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating the cart link customizations at checkout.
/// </summary>
public record CheckoutBrandingCartLinkInput : GraphQLInputObject<CheckoutBrandingCartLinkInput>
{
    /// <summary>
    /// The input to update the visibility of cart links in checkout. This hides the
    /// cart icon on one-page and the cart link in the breadcrumbs/buyer journey on
    /// three-page checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}