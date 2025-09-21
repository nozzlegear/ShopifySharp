#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a single move of an object to a specific position in a set, using a zero-based index.
/// </summary>
public record MoveInput : GraphQLInputObject<MoveInput>
{
    /// <summary>
    /// The ID of the object to be moved.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The new position of the object in the set.
    /// </summary>
    [JsonPropertyName("newPosition")]
    public ulong? newPosition { get; set; } = null;
}