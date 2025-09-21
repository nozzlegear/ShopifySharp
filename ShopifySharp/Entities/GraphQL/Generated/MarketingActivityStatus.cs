#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Status helps to identify if this marketing activity has been completed, queued, failed etc.
/// </summary>
public enum MarketingActivityStatus
{
    ACTIVE,
    DELETED,
    DELETED_EXTERNALLY,
    DISCONNECTED,
    DRAFT,
    FAILED,
    INACTIVE,
    PAUSED,
    PENDING,
    SCHEDULED,
    UNDEFINED,
}