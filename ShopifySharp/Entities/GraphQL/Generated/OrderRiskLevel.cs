#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The likelihood that an order is fraudulent.
/// This enum is deprecated in favor of
/// [RiskAssessmentResult](https://shopify.dev/api/admin-graphql/latest/enums/RiskAssessmentResult)
/// which allows for more granular risk levels, including PENDING and NONE.
/// </summary>
public enum OrderRiskLevel
{
    LOW,
    MEDIUM,
    HIGH,
}