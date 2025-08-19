#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create payment terms. Payment terms set the date that payment is due.
/// </summary>
public record PaymentTermsInput : GraphQLInputObject<PaymentTermsInput>
{
    /// <summary>
    /// Specifies the payment schedules for the payment terms.
    /// </summary>
    [JsonPropertyName("paymentSchedules")]
    public ICollection<PaymentScheduleInput>? paymentSchedules { get; set; } = null;

    /// <summary>
    /// Specifies the ID of the payment terms template.
    ///         Payment terms templates provide preset configurations to create common payment terms.
    ///         Refer to the
    ///         [PaymentTermsTemplate](https://shopify.dev/api/admin-graphql/latest/objects/paymenttermstemplate)
    ///         object for more details.
    /// </summary>
    [JsonPropertyName("paymentTermsTemplateId")]
    public string? paymentTermsTemplateId { get; set; } = null;
}