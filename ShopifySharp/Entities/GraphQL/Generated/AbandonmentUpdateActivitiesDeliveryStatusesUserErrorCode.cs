#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `AbandonmentUpdateActivitiesDeliveryStatusesUserError`.
/// </summary>
public enum AbandonmentUpdateActivitiesDeliveryStatusesUserErrorCode
{
    ABANDONMENT_NOT_FOUND,
    MARKETING_ACTIVITY_NOT_FOUND,
    DELIVERY_STATUS_INFO_NOT_FOUND,
}