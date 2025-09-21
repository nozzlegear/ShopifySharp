#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `customerMerge` mutation.
/// </summary>
public record CustomerMergePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job for merging the customers.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The ID of the customer resulting from the merge.
    /// </summary>
    [JsonPropertyName("resultingCustomerId")]
    public string? resultingCustomerId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerMergeUserError>? userErrors { get; set; } = null;
}