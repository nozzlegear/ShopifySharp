#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a reverse fulfillment order third-party confirmation.
/// </summary>
public enum ReverseFulfillmentOrderThirdPartyConfirmationStatus
{
    ACCEPTED,
    CANCEL_ACCEPTED,
    CANCEL_REJECTED,
    PENDING_ACCEPTANCE,
    PENDING_CANCELATION,
    REJECTED,
}