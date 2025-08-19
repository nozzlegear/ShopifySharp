#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderCancel` mutation.
/// </summary>
public record OrderCancelPayload : IGraphQLObject
{
    /// <summary>
    /// The job that asynchronously cancels the order.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("orderCancelUserErrors")]
    public ICollection<OrderCancelUserError>? orderCancelUserErrors { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    [Obsolete("Use `orderCancelUserErrors` instead.")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}