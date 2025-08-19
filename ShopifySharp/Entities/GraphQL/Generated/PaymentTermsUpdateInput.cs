#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the payment terms.
/// </summary>
public record PaymentTermsUpdateInput : GraphQLInputObject<PaymentTermsUpdateInput>
{
    /// <summary>
    /// The attributes used to update the payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsAttributes")]
    public PaymentTermsInput? paymentTermsAttributes { get; set; } = null;

    /// <summary>
    /// The ID of the payment terms being updated.
    /// </summary>
    [JsonPropertyName("paymentTermsId")]
    public string? paymentTermsId { get; set; } = null;
}