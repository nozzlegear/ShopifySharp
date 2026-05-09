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
/// Return type for `pointOfSaleDevicePaymentSessionOpen` mutation.
/// </summary>
public record PointOfSaleDevicePaymentSessionOpenPayload : IGraphQLObject
{
    /// <summary>
    /// The created point of sale device payment session.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevicePaymentSession")]
    public PointOfSaleDevicePaymentSession? pointOfSaleDevicePaymentSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PointOfSaleDevicePaymentSessionOpenUserError>? userErrors { get; set; } = null;
}