#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderCustomerRemove` mutation.
/// </summary>
public record OrderCustomerRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The order that had its customer removed.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderCustomerRemoveUserError>? userErrors { get; set; } = null;
}