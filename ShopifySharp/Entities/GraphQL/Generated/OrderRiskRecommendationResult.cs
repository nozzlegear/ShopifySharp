#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// List of possible values for an OrderRiskRecommendation recommendation.
/// </summary>
public enum OrderRiskRecommendationResult
{
    CANCEL,
    INVESTIGATE,
    ACCEPT,
    NONE,
}