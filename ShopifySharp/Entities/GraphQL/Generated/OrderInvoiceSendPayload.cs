#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderInvoiceSend` mutation.
/// </summary>
public record OrderInvoiceSendPayload : IGraphQLObject
{
    /// <summary>
    /// The order associated with the invoice email.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderInvoiceSendUserError>? userErrors { get; set; } = null;
}