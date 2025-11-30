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
/// List of possible values for a RiskFact sentiment.
/// </summary>
public enum RiskFactSentiment
{
    POSITIVE,
    NEUTRAL,
    NEGATIVE,
}