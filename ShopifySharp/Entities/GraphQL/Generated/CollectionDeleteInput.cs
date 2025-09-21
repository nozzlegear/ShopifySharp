#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for specifying the collection to delete.
/// </summary>
public record CollectionDeleteInput : GraphQLInputObject<CollectionDeleteInput>
{
    /// <summary>
    /// The ID of the collection to be deleted.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}