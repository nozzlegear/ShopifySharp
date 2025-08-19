#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `PaymentReminderSendUserError`.
/// </summary>
public enum PaymentReminderSendUserErrorCode
{
    PAYMENT_REMINDER_SEND_UNSUCCESSFUL,
}