#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to create a payment terms.
/// </summary>
public record PaymentTermsCreateInput : GraphQLInputObject<PaymentTermsCreateInput>
{
    /// <summary>
    /// Specifies the payment schedules for the payment terms.
    /// </summary>
    [JsonPropertyName("paymentSchedules")]
    public ICollection<PaymentScheduleInput>? paymentSchedules { get; set; } = null;

    /// <summary>
    /// Specifies the payment terms template ID used to generate payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsTemplateId")]
    public string? paymentTermsTemplateId { get; set; } = null;
}