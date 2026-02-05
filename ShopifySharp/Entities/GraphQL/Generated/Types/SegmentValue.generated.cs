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
/// A list of suggested values associated with an individual segment. A
/// segment is a group of members, such as customers, that meet specific
/// criteria.
/// </summary>
public record SegmentValue : IGraphQLObject
{
    /// <summary>
    /// The localized version of the value's name. This name is displayed to the merchant.
    /// </summary>
    [JsonPropertyName("localizedValue")]
    public string? localizedValue { get; set; } = null;

    /// <summary>
    /// The name of the query associated with the suggestion.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName_ { get; set; } = null;
}