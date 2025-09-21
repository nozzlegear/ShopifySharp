#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to specify the draft order to delete by its ID.
/// </summary>
public record DraftOrderDeleteInput : GraphQLInputObject<DraftOrderDeleteInput>
{
    /// <summary>
    /// The ID of the draft order to delete.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}