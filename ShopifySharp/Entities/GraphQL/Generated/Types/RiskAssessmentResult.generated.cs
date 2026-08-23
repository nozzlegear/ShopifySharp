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
/// Possible risk levels for an order risk assessment.
/// </summary>
public enum RiskAssessmentResult
{
    HIGH,
    MEDIUM,
    LOW,
    NONE,
    PENDING,
}