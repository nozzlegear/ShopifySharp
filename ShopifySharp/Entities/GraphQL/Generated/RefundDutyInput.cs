#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to reimburse duties on a refund.
/// </summary>
public record RefundDutyInput : GraphQLInputObject<RefundDutyInput>
{
    /// <summary>
    /// The ID of the duty in the refund.
    /// </summary>
    [JsonPropertyName("dutyId")]
    public string? dutyId { get; set; } = null;

    /// <summary>
    /// The type of refund for this duty.
    /// </summary>
    [JsonPropertyName("refundType")]
    public RefundDutyRefundType? refundType { get; set; } = null;
}