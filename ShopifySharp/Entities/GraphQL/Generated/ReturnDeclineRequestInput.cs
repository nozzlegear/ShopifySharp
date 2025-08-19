#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for declining a customer's return request.
/// </summary>
public record ReturnDeclineRequestInput : GraphQLInputObject<ReturnDeclineRequestInput>
{
    /// <summary>
    /// The notification message that's sent to a customer about their declined return request.
    /// Maximum length: 500 characters.
    /// </summary>
    [JsonPropertyName("declineNote")]
    public string? declineNote { get; set; } = null;

    /// <summary>
    /// The reason why the merchant declined the customer's return request.
    /// </summary>
    [JsonPropertyName("declineReason")]
    public ReturnDeclineReason? declineReason { get; set; } = null;

    /// <summary>
    /// The ID of the return that's being declined.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Notify the customer when a return request is declined.
    /// The customer will only receive a notification if `Order.email` is present.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;
}