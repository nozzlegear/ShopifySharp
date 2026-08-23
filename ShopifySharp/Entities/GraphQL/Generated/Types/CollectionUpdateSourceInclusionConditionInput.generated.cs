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
/// The input fields for updating a condition in a collection source.
/// </summary>
public record CollectionUpdateSourceInclusionConditionInput : GraphQLInputObject<CollectionUpdateSourceInclusionConditionInput>
{
    /// <summary>
    /// The updated condition.
    /// </summary>
    [JsonPropertyName("condition")]
    public CollectionSourceInclusionConditionUpdateInput? condition { get; set; } = null;

    /// <summary>
    /// The ID of the condition to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}