#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `orderCreateMandatePayment` mutation.
/// </summary>
public record OrderCreateMandatePaymentPayload : IGraphQLObject
{
    /// <summary>
    /// The async job used for charging the payment.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The Unique ID for the created payment.
    /// </summary>
    [JsonPropertyName("paymentReferenceId")]
    public string? paymentReferenceId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderCreateMandatePaymentUserError>? userErrors { get; set; } = null;
}