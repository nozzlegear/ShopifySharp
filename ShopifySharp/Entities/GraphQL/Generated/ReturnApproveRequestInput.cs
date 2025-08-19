#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for approving a customer's return request.
/// </summary>
public record ReturnApproveRequestInput : GraphQLInputObject<ReturnApproveRequestInput>
{
    /// <summary>
    /// The ID of the return that's being approved.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Notify the customer when a return request is approved.
    /// The customer will only receive a notification if `Order.email` is present.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;
}