#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to delete the payment terms.
/// </summary>
public record PaymentTermsDeleteInput : GraphQLInputObject<PaymentTermsDeleteInput>
{
    /// <summary>
    /// The ID of the payment terms being deleted.
    /// </summary>
    [JsonPropertyName("paymentTermsId")]
    public string? paymentTermsId { get; set; } = null;
}