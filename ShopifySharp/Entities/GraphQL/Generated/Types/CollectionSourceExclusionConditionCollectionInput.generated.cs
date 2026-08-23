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
/// The input fields for an exclusion condition based on collections.
/// </summary>
public record CollectionSourceExclusionConditionCollectionInput : GraphQLInputObject<CollectionSourceExclusionConditionCollectionInput>
{
    /// <summary>
    /// The collection IDs whose products are excluded.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}