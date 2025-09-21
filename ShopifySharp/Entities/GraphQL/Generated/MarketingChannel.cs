#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The medium through which the marketing activity and event reached consumers. This is used for reporting aggregation.
/// </summary>
public enum MarketingChannel
{
    SEARCH,
    DISPLAY,
    SOCIAL,
    EMAIL,
    REFERRAL,
}