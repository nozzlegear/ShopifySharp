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
/// The input fields for updating an exclusion condition based on collections.
/// </summary>
public record CollectionSourceExclusionConditionUpdateCollectionInput : GraphQLInputObject<CollectionSourceExclusionConditionUpdateCollectionInput>
{
    /// <summary>
    /// The collection IDs whose products are excluded.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}