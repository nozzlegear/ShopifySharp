#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A customer's computed statistics.
/// </summary>
public record CustomerStatistics : IGraphQLObject
{
    /// <summary>
    /// The predicted spend tier of a customer with a shop.
    /// </summary>
    [JsonPropertyName("predictedSpendTier")]
    public CustomerPredictedSpendTier? predictedSpendTier { get; set; } = null;

    /// <summary>
    /// The RFM (Recency, Frequency, Monetary) group of the customer.
    /// </summary>
    [JsonPropertyName("rfmGroup")]
    public CustomerRfmGroup? rfmGroup { get; set; } = null;
}