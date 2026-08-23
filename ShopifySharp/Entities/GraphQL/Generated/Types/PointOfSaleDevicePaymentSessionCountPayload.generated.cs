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
/// Return type for `pointOfSaleDevicePaymentSessionCount` mutation.
/// </summary>
public record PointOfSaleDevicePaymentSessionCountPayload : IGraphQLObject
{
    /// <summary>
    /// The point of sale device payment session after recording the count.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevicePaymentSession")]
    public PointOfSaleDevicePaymentSession? pointOfSaleDevicePaymentSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PointOfSaleDevicePaymentSessionCountUserError>? userErrors { get; set; } = null;
}