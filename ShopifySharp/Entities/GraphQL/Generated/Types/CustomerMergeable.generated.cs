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
/// An object that represents whether a customer can be merged with another customer.
/// </summary>
public record CustomerMergeable : IGraphQLObject
{
    /// <summary>
    /// The list of fields preventing the customer from being merged.
    /// </summary>
    [JsonPropertyName("errorFields")]
    public ICollection<CustomerMergeErrorFieldType>? errorFields { get; set; } = null;

    /// <summary>
    /// Whether the customer can be merged with another customer.
    /// </summary>
    [JsonPropertyName("isMergeable")]
    public bool? isMergeable { get; set; } = null;

    /// <summary>
    /// The merge request if one is currently in progress.
    /// </summary>
    [JsonPropertyName("mergeInProgress")]
    public CustomerMergeRequest? mergeInProgress { get; set; } = null;

    /// <summary>
    /// The reason why the customer can't be merged with another customer.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? reason { get; set; } = null;
}