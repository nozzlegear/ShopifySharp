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
/// The error blocking a customer merge.
/// </summary>
public record CustomerMergeError : IGraphQLObject
{
    /// <summary>
    /// The list of fields preventing the customer from being merged.
    /// </summary>
    [JsonPropertyName("errorFields")]
    public ICollection<CustomerMergeErrorFieldType>? errorFields { get; set; } = null;

    /// <summary>
    /// The customer merge error message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}