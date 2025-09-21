#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a dispute file upload object.
/// </summary>
public record ShopifyPaymentsDisputeFileUploadUpdateInput : GraphQLInputObject<ShopifyPaymentsDisputeFileUploadUpdateInput>
{
    /// <summary>
    /// Whether to delete this file upload.
    /// </summary>
    [JsonPropertyName("destroy")]
    public bool? destroy { get; set; } = null;

    /// <summary>
    /// The ID of the file upload to be updated.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}