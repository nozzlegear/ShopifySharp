#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The budget type for a marketing activity.
/// </summary>
public enum MarketingBudgetBudgetType
{
    DAILY,
    LIFETIME,
}