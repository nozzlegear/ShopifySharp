#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentReminderSend` mutation.
/// </summary>
public record PaymentReminderSendPayload : IGraphQLObject
{
    /// <summary>
    /// Whether the payment reminder email was successfully sent.
    /// </summary>
    [JsonPropertyName("success")]
    public bool? success { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentReminderSendUserError>? userErrors { get; set; } = null;
}