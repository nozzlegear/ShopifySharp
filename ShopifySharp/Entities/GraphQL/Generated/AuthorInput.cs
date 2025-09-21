#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an author. Either the `name` or `user_id` fields can be supplied, but never both.
/// </summary>
public record AuthorInput : GraphQLInputObject<AuthorInput>
{
    /// <summary>
    /// The author's full name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The ID of a staff member's account.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? userId { get; set; } = null;
}