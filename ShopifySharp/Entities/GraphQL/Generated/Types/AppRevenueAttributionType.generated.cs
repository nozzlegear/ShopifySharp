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
/// Represents the billing types of revenue attribution.
/// </summary>
public enum AppRevenueAttributionType
{
    APPLICATION_PURCHASE,
    APPLICATION_SUBSCRIPTION,
    APPLICATION_USAGE,
    OTHER,
}