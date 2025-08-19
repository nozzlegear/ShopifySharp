#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `bulkProductResourceFeedbackCreate` mutation.
/// </summary>
public record BulkProductResourceFeedbackCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The feedback that's created.
    /// </summary>
    [JsonPropertyName("feedback")]
    public ICollection<ProductResourceFeedback>? feedback { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BulkProductResourceFeedbackCreateUserError>? userErrors { get; set; } = null;
}