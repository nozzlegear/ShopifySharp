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
/// Specifies the taxonomy category to used for the condition.
/// </summary>
public record CollectionRuleCategoryCondition : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The taxonomy category used as condition.
    /// </summary>
    [JsonPropertyName("value")]
    public TaxonomyCategory? @value { get; set; } = null;
}