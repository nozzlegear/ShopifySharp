#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a summary of the current version of data in a resource.
/// The `compare_digest` field can be used as input for mutations that implement a compare-and-swap mechanism.
/// </summary>
public interface IHasCompareDigest : IGraphQLObject
{
    /// <summary>
    /// The data stored in the resource, represented as a digest.
    /// </summary>
    [JsonPropertyName("compareDigest")]
    public string? compareDigest { get; set; }
}