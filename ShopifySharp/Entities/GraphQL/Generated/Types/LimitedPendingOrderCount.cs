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
/// The total number of pending orders on a shop if less then a maximum, or that maximum.
/// The atMax field indicates when this maximum has been reached.
/// </summary>
public record LimitedPendingOrderCount : IGraphQLObject
{
    /// <summary>
    /// This is set when the number of pending orders has reached the maximum.
    /// </summary>
    [JsonPropertyName("atMax")]
    public bool? atMax { get; set; } = null;

    /// <summary>
    /// The number of pendings orders on the shop.
    /// Limited to a maximum of 10000.
    /// </summary>
    [JsonPropertyName("count")]
    public int? count { get; set; } = null;
}