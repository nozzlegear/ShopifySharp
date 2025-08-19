#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create a carrier service.
/// </summary>
public record DeliveryCarrierServiceCreateInput : GraphQLInputObject<DeliveryCarrierServiceCreateInput>
{
    /// <summary>
    /// Whether this carrier service is active. If `true`, then the service will be available to serve rates in checkout.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The URL endpoint that Shopify needs to retrieve shipping rates. This must be a public URL.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? callbackUrl { get; set; } = null;

    /// <summary>
    /// The name of the shipping service as seen by merchants and their customers.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether merchants are able to send dummy data to your service through the Shopify admin to see shipping rate examples.
    /// </summary>
    [JsonPropertyName("supportsServiceDiscovery")]
    public bool? supportsServiceDiscovery { get; set; } = null;
}