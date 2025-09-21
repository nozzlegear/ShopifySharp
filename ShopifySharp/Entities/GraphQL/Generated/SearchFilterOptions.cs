#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A list of search filters along with their specific options in value and label pair for filtering.
/// </summary>
public record SearchFilterOptions : IGraphQLObject
{
    /// <summary>
    /// A list of options that can be use to filter product availability.
    /// </summary>
    [JsonPropertyName("productAvailability")]
    public ICollection<FilterOption>? productAvailability { get; set; } = null;
}