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
/// Provides access to the cart transform feature configuration for the merchant's
/// store. This wrapper object indicates whether cart transformation capabilities
/// are enabled and what operations are available.
/// For example, when checking if your app can deploy customized bundle features,
/// you would query this object to confirm cart transforms are supported and review
/// the eligible operations.
/// The feature configuration helps apps determine compatibility before attempting to create transform functions.
/// Learn more about [cart transformation](https://shopify.dev/docs/api/admin-graphql/latest/objects/CartTransform).
/// </summary>
public record CartTransformFeature : IGraphQLObject
{
    /// <summary>
    /// The cart transform operations eligible for the shop.
    /// </summary>
    [JsonPropertyName("eligibleOperations")]
    public CartTransformEligibleOperations? eligibleOperations { get; set; } = null;
}