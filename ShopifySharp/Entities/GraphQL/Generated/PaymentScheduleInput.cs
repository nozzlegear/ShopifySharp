#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to create a payment schedule for payment terms.
/// </summary>
public record PaymentScheduleInput : GraphQLInputObject<PaymentScheduleInput>
{
    /// <summary>
    /// Specifies the date and time when the payment schedule is due. This field must be provided for fixed type payment terms.
    /// </summary>
    [JsonPropertyName("dueAt")]
    public DateTime? dueAt { get; set; } = null;

    /// <summary>
    /// Specifies the date and time that the payment schedule was issued. This field must be provided for net type payment terms.
    /// </summary>
    [JsonPropertyName("issuedAt")]
    public DateTime? issuedAt { get; set; } = null;
}