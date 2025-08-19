#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible dispute evidence file types.
/// </summary>
public enum ShopifyPaymentsDisputeEvidenceFileType
{
    CUSTOMER_COMMUNICATION_FILE,
    REFUND_POLICY_FILE,
    CANCELLATION_POLICY_FILE,
    UNCATEGORIZED_FILE,
    SHIPPING_DOCUMENTATION_FILE,
    SERVICE_DOCUMENTATION_FILE,
}