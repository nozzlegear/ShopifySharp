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
/// An inventory-related error that occurred during a subscription billing attempt.
/// </summary>
public record SubscriptionBillingAttemptInventoryError : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The error code for the inventory-related failure.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptInventoryErrorCode? code { get; set; } = null;

    /// <summary>
    /// A list of product variants that caused the insufficient inventory error.
    /// </summary>
    [JsonPropertyName("insufficientStockProductVariants")]
    public ProductVariantConnection? insufficientStockProductVariants { get; set; } = null;
}