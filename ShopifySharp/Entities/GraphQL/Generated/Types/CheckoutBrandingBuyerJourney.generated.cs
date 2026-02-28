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
/// Controls the visibility settings for checkout breadcrumb navigation that shows
/// customers their progress through the purchase journey. This simple customization
/// allows merchants to show or hide the breadcrumb trail based on their checkout
/// flow preferences.
/// For example, a single-page checkout experience might hide breadcrumbs to create
/// a more streamlined appearance, while multi-step checkouts can display them to
/// help customers understand their progress.
/// The visibility setting provides merchants flexibility in how they present
/// checkout navigation to match their specific user experience strategy.
/// Learn more about [checkout customization](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutBranding).
/// </summary>
public record CheckoutBrandingBuyerJourney : IGraphQLObject
{
    /// <summary>
    /// An option to display or hide the breadcrumbs that represent the buyer's journey on 3-page checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}