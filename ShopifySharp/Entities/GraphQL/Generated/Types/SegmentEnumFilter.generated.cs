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
/// Categorical filter options for building customer segments using predefined value
/// sets like countries, subscription statuses, or order frequencies.
/// For example, a "Customer Location" enum filter provides options like "United States," "Canada," and "United Kingdom."
/// Use this object to:
/// - Access available categorical filter options
/// - Understand filter capabilities and constraints
/// - Build user interfaces for segment creation
/// Includes localized display names, indicates whether multiple values can be
/// selected, and provides technical query names for API operations.
/// </summary>
public record SegmentEnumFilter : IGraphQLObject, ISegmentFilter
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; } = null;

    /// <summary>
    /// Whether a file can have multiple values for a single customer.
    /// </summary>
    [JsonPropertyName("multiValue")]
    public bool? multiValue { get; set; } = null;

    /// <summary>
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName_ { get; set; } = null;
}