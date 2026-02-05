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
/// StatusBadgeType helps to identify the color of the status badge.
/// </summary>
public enum MarketingActivityStatusBadgeType
{
    DEFAULT,
    SUCCESS,
    ATTENTION,
    WARNING,
    INFO,
    CRITICAL,
}