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
/// Hierarchy levels for external marketing activities.
/// </summary>
public enum MarketingActivityHierarchyLevel
{
    AD,
    AD_GROUP,
    CAMPAIGN,
}