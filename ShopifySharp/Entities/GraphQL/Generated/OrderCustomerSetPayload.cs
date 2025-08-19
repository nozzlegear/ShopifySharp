#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderCustomerSet` mutation.
/// </summary>
public record OrderCustomerSetPayload : IGraphQLObject
{
    /// <summary>
    /// The order that had a customer set.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderCustomerSetUserError>? userErrors { get; set; } = null;
}