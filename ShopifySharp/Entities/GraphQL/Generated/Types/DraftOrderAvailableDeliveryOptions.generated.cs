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
/// The available delivery options for a draft order.
/// </summary>
public record DraftOrderAvailableDeliveryOptions : IGraphQLObject
{
    /// <summary>
    /// The available local delivery rates for the draft order. Requires a customer
    /// with a valid shipping address and at least one line item.
    /// </summary>
    [JsonPropertyName("availableLocalDeliveryRates")]
    public ICollection<DraftOrderShippingRate>? availableLocalDeliveryRates { get; set; } = null;

    /// <summary>
    /// The available local pickup options for the draft order. Requires at least one line item.
    /// </summary>
    [JsonPropertyName("availableLocalPickupOptions")]
    public ICollection<PickupInStoreLocation>? availableLocalPickupOptions { get; set; } = null;

    /// <summary>
    /// The available shipping rates for the draft order. Requires a customer with a
    /// valid shipping address and at least one line item.
    /// </summary>
    [JsonPropertyName("availableShippingRates")]
    public ICollection<DraftOrderShippingRate>? availableShippingRates { get; set; } = null;

    /// <summary>
    /// Returns information about pagination of local pickup options.
    /// </summary>
    [JsonPropertyName("pageInfo")]
    public PageInfo? pageInfo { get; set; } = null;
}