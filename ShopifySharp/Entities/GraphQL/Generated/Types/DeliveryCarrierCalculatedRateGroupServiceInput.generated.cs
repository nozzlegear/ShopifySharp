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
/// The input fields for including or excluding a carrier-provided service in a rate group.
/// </summary>
public record DeliveryCarrierCalculatedRateGroupServiceInput : GraphQLInputObject<DeliveryCarrierCalculatedRateGroupServiceInput>
{
    /// <summary>
    /// The name of the carrier-provided service.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether this service is included or excluded at checkout.
    /// </summary>
    [JsonPropertyName("status")]
    public DeliveryCarrierCalculatedRateGroupServiceStatus? status { get; set; } = null;
}