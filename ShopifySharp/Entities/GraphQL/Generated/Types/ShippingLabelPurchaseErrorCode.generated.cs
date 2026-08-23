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
/// Possible error codes that can be returned by `ShippingLabelPurchaseError`.
/// </summary>
public enum ShippingLabelPurchaseErrorCode
{
    JOB_NOT_ENQUEUED,
    PURCHASE_IN_PROGRESS,
    PURCHASE_LABEL_VALIDATION_ERROR,
    KILL_SWITCH,
    CARRIER_NOT_AVAILABLE,
    DISABLED_SHIPPING_ACCOUNT,
    CONNECTION_ERROR,
    TRANSIENT_ERROR,
    PERMANENT_ERROR,
    UNKNOWN_ERROR,
}