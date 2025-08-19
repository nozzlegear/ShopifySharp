#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Set of possible statuses for an external marketing activity.
/// </summary>
public enum MarketingActivityExternalStatus
{
    ACTIVE,
    INACTIVE,
    PAUSED,
    SCHEDULED,
    DELETED_EXTERNALLY,
    UNDEFINED,
}