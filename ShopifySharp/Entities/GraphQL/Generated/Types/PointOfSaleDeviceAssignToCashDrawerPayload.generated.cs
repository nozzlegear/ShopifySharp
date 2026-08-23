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
/// Return type for `pointOfSaleDeviceAssignToCashDrawer` mutation.
/// </summary>
public record PointOfSaleDeviceAssignToCashDrawerPayload : IGraphQLObject
{
    /// <summary>
    /// The point of sale device.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevice")]
    public PointOfSaleDevice? pointOfSaleDevice { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PointOfSaleDeviceAssignToCashDrawerUserError>? userErrors { get; set; } = null;
}