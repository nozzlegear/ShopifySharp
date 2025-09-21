#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The file upload associated with the dispute evidence.
/// </summary>
public record ShopifyPaymentsDisputeFileUpload : IGraphQLObject, INode
{
    /// <summary>
    /// The type of the file for the dispute evidence.
    /// </summary>
    [JsonPropertyName("disputeEvidenceType")]
    public ShopifyPaymentsDisputeEvidenceFileType? disputeEvidenceType { get; set; } = null;

    /// <summary>
    /// The file size.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public int? fileSize { get; set; } = null;

    /// <summary>
    /// The file type.
    /// </summary>
    [JsonPropertyName("fileType")]
    public string? fileType { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The original file name.
    /// </summary>
    [JsonPropertyName("originalFileName")]
    public string? originalFileName { get; set; } = null;

    /// <summary>
    /// The URL for accessing the file.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}