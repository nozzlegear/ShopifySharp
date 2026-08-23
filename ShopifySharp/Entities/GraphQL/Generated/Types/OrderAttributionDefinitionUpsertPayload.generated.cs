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
/// Return type for `orderAttributionDefinitionUpsert` mutation.
/// </summary>
public record OrderAttributionDefinitionUpsertPayload : IGraphQLObject
{
    /// <summary>
    /// The order attribution definition that was upserted.
    /// </summary>
    [JsonPropertyName("orderAttributionDefinition")]
    public OrderAttributionDefinition? orderAttributionDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderAttributionDefinitionUpsertUserError>? userErrors { get; set; } = null;
}