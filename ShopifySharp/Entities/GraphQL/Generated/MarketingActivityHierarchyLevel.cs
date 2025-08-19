#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Hierarchy levels for external marketing activities.
/// </summary>
public enum MarketingActivityHierarchyLevel
{
    AD,
    AD_GROUP,
    CAMPAIGN,
}