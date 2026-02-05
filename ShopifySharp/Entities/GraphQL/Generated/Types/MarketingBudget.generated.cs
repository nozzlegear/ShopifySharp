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
/// This type combines budget amount and its marketing budget type.
/// </summary>
public record MarketingBudget : IGraphQLObject
{
    /// <summary>
    /// The budget type for a marketing activity.
    /// </summary>
    [JsonPropertyName("budgetType")]
    public MarketingBudgetBudgetType? budgetType { get; set; } = null;

    /// <summary>
    /// The amount of budget for marketing activity.
    /// </summary>
    [JsonPropertyName("total")]
    public MoneyV2? total { get; set; } = null;
}