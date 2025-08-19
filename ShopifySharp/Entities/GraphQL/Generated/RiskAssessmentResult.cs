#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// List of possible values for a RiskAssessment result.
/// </summary>
public enum RiskAssessmentResult
{
    HIGH,
    MEDIUM,
    LOW,
    NONE,
    PENDING,
}