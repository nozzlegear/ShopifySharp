#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a product duplication job.
/// </summary>
public record ProductDuplicateJob : IGraphQLObject
{
    /// <summary>
    /// This indicates if the job is still queued or has been run.
    /// </summary>
    [JsonPropertyName("done")]
    public bool? done { get; set; } = null;

    /// <summary>
    /// A globally-unique ID that's returned when running an asynchronous mutation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}