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