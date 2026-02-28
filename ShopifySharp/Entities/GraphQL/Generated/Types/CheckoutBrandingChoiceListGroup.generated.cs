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
/// Controls the spacing between options in the 'group' variant of [`ChoiceList`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutBrandingChoiceList) components.
/// This setting adjusts the vertical spacing between choice options to improve
/// readability and visual organization. The spacing value helps create clear
/// separation between options, making it easier for customers to scan and select
/// from available choices.
/// Learn more about [checkout customization](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutBranding).
/// </summary>
public record CheckoutBrandingChoiceListGroup : IGraphQLObject
{
    /// <summary>
    /// The spacing between UI elements in the list.
    /// </summary>
    [JsonPropertyName("spacing")]
    public CheckoutBrandingSpacingKeyword? spacing { get; set; } = null;
}