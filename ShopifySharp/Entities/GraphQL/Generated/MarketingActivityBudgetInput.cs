#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields combining budget amount and its marketing budget type.
/// </summary>
public record MarketingActivityBudgetInput : GraphQLInputObject<MarketingActivityBudgetInput>
{
    /// <summary>
    /// Budget type for marketing activity.
    /// </summary>
    [JsonPropertyName("budgetType")]
    public MarketingBudgetBudgetType? budgetType { get; set; } = null;

    /// <summary>
    /// Amount of budget for the marketing activity.
    /// </summary>
    [JsonPropertyName("total")]
    public MoneyInput? total { get; set; } = null;
}