#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to delete a saved search.
/// </summary>
public record SavedSearchDeleteInput : GraphQLInputObject<SavedSearchDeleteInput>
{
    /// <summary>
    /// ID of the saved search to delete.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}