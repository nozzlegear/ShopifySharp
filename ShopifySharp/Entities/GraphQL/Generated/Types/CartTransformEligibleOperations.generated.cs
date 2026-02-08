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
/// Controls which cart transformation operations apps can perform in your store.
/// This lets you define exactly what types of cart modifications are allowed based
/// on your checkout setup and business needs.
/// The eligible operations determine what cart transform functions can accomplish,
/// providing a clear boundary for app capabilities within the store's ecosystem.
/// Learn more about [cart transform operations](https://shopify.dev/docs/api/functions/latest/cart-transform#multiple-operations).
/// </summary>
public record CartTransformEligibleOperations : IGraphQLObject
{
    /// <summary>
    /// The shop is eligible for expand operations.
    /// </summary>
    [JsonPropertyName("expandOperation")]
    public bool? expandOperation { get; set; } = null;

    /// <summary>
    /// The shop is eligible for merge operations.
    /// </summary>
    [JsonPropertyName("mergeOperation")]
    public bool? mergeOperation { get; set; } = null;

    /// <summary>
    /// The shop is eligible for update operations.
    /// </summary>
    [JsonPropertyName("updateOperation")]
    public bool? updateOperation { get; set; } = null;
}