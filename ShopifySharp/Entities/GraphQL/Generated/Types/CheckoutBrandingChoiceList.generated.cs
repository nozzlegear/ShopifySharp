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
/// Controls spacing customization for the grouped variant of choice list components in checkout forms.
/// The `ChoiceList` object contains settings specifically for the 'group' variant
/// styling through the [`ChoiceListGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutBrandingChoiceListGroup)
/// field, which determines the spacing between choice options.
/// </summary>
public record CheckoutBrandingChoiceList : IGraphQLObject
{
    /// <summary>
    /// The settings that apply to the 'group' variant of ChoiceList.
    /// </summary>
    [JsonPropertyName("group")]
    public CheckoutBrandingChoiceListGroup? @group { get; set; } = null;
}