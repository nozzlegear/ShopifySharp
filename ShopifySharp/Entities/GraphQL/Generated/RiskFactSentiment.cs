#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// List of possible values for a RiskFact sentiment.
/// </summary>
public enum RiskFactSentiment
{
    POSITIVE,
    NEUTRAL,
    NEGATIVE,
}