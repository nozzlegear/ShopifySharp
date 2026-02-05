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
/// An inventory error caused by an issue with one or more of the contract merchandise lines.
/// </summary>
public record SubscriptionBillingAttemptOutOfStockProductVariantsError : IGraphQLObject, ISubscriptionBillingAttemptProcessingError
{
    /// <summary>
    /// The code for the error.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptErrorCode? code { get; set; } = null;

    /// <summary>
    /// An explanation of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// A list of responsible product variants.
    /// </summary>
    [JsonPropertyName("outOfStockProductVariants")]
    [Obsolete("Use `subscriptionBillingAttemptInsufficientStockProductVariantsError` type instead.")]
    public ProductVariantConnection? outOfStockProductVariants { get; set; } = null;
}