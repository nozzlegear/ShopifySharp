#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An inventory error caused by an issue with one or more of the contract merchandise lines.
/// </summary>
public record SubscriptionBillingAttemptInsufficientStockProductVariantsError : IGraphQLObject, ISubscriptionBillingAttemptProcessingError
{
    /// <summary>
    /// The code for the error.
    /// </summary>
    [JsonPropertyName("code")]
    public SubscriptionBillingAttemptErrorCode? code { get; set; } = null;

    /// <summary>
    /// A list of product variants that caused the insufficient inventory error.
    /// </summary>
    [JsonPropertyName("insufficientStockProductVariants")]
    public ProductVariantConnection? insufficientStockProductVariants { get; set; } = null;

    /// <summary>
    /// An explanation of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}