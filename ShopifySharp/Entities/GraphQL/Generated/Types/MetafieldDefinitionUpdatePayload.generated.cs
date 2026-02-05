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
/// Return type for `metafieldDefinitionUpdate` mutation.
/// </summary>
public record MetafieldDefinitionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The metafield definition that was updated.
    /// </summary>
    [JsonPropertyName("updatedDefinition")]
    public MetafieldDefinition? updatedDefinition { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldDefinitionUpdateUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The asynchronous job updating the metafield definition's validation_status.
    /// </summary>
    [JsonPropertyName("validationJob")]
    public Job? validationJob { get; set; } = null;
}