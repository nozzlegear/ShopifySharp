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
/// A constraint subtype value that the metafield definition applies to.
/// </summary>
public record MetafieldDefinitionConstraintValue : IGraphQLObject
{
    /// <summary>
    /// The subtype value of the constraint.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}