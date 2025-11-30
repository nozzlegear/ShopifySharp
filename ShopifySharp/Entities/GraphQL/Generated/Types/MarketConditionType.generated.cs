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
/// The condition types for the condition set.
/// </summary>
public enum MarketConditionType
{
    REGION,
    LOCATION,
    COMPANY_LOCATION,
}