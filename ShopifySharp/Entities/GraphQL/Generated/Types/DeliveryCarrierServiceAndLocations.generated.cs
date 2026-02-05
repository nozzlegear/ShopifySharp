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
/// Links a [`DeliveryCarrierService`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DeliveryCarrierService) with the associated shop
/// [locations](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
/// where it can calculate shipping rates. Each pairing indicates the locations that
/// can use a specific carrier service for real-time rate calculations during checkout.
/// The carrier service provides the shipping rate calculation logic, while the
/// locations represent physical or virtual fulfillment points that can ship orders
/// using that service.
/// </summary>
public record DeliveryCarrierServiceAndLocations : IGraphQLObject
{
    /// <summary>
    /// The carrier service.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The list of locations that support this carrier service.
    /// </summary>
    [JsonPropertyName("locations")]
    public ICollection<Location>? locations { get; set; } = null;
}