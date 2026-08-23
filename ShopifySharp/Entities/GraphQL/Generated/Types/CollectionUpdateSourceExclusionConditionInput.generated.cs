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
/// The input fields for updating an exclusion condition in a collection source.
/// </summary>
public record CollectionUpdateSourceExclusionConditionInput : GraphQLInputObject<CollectionUpdateSourceExclusionConditionInput>
{
    /// <summary>
    /// The updated exclusion condition.
    /// </summary>
    [JsonPropertyName("condition")]
    public CollectionSourceExclusionConditionUpdateInput? condition { get; set; } = null;

    /// <summary>
    /// The ID of the exclusion condition to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}