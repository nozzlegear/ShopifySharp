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
/// Return type for `pointOfSaleDevicePaymentSessionClose` mutation.
/// </summary>
public record PointOfSaleDevicePaymentSessionClosePayload : IGraphQLObject
{
    /// <summary>
    /// The closed point of sale device payment session.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevicePaymentSession")]
    public PointOfSaleDevicePaymentSession? pointOfSaleDevicePaymentSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PointOfSaleDevicePaymentSessionCloseUserError>? userErrors { get; set; } = null;
}