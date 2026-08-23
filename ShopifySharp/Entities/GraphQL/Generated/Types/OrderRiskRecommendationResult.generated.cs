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
/// Possible recommendations for an order.
/// </summary>
public enum OrderRiskRecommendationResult
{
    CANCEL,
    INVESTIGATE,
    ACCEPT,
    NONE,
}