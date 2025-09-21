#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A job corresponds to some long running task that the client should poll for status.
/// </summary>
public record Job : IGraphQLObject
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

    /// <summary>
    /// This field will only resolve once the job is done. Can be used to ask for object(s) that have been changed by the job.
    /// </summary>
    [JsonPropertyName("query")]
    public QueryRoot? query { get; set; } = null;
}