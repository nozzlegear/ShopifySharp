#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible types for a badge.
/// </summary>
public enum BadgeType
{
    DEFAULT,
    SUCCESS,
    ATTENTION,
    WARNING,
    INFO,
    CRITICAL,
}