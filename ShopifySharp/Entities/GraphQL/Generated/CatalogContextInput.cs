#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the context in which the catalog's publishing and pricing rules apply.
/// </summary>
public record CatalogContextInput : GraphQLInputObject<CatalogContextInput>
{
    /// <summary>
    /// The IDs of the company locations to associate to the catalog.
    /// </summary>
    [JsonPropertyName("companyLocationIds")]
    public ICollection<string>? companyLocationIds { get; set; } = null;

    /// <summary>
    /// The IDs of the markets to associate to the catalog.
    /// </summary>
    [JsonPropertyName("marketIds")]
    public ICollection<string>? marketIds { get; set; } = null;
}