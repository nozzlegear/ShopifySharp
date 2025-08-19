#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the delivery state of a marketing activity.
/// </summary>
public enum AbandonmentDeliveryState
{
    NOT_SENT,
    SENT,
    SCHEDULED,
}