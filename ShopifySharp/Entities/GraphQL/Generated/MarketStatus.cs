#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible market statuses.
/// </summary>
public enum MarketStatus
{
    ACTIVE,
    DRAFT,
}