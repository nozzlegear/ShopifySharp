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
/// The input fields used to update a catalog.
/// </summary>
public record CatalogUpdateInput : GraphQLInputObject<CatalogUpdateInput>
{
    /// <summary>
    /// The context associated with the catalog.
    /// </summary>
    [JsonPropertyName("context")]
    public CatalogContextInput? context { get; set; } = null;

    /// <summary>
    /// The ID of the price list to associate to the catalog.
    /// </summary>
    [JsonPropertyName("priceListId")]
    public string? priceListId { get; set; } = null;

    /// <summary>
    /// The ID of the publication to associate to the catalog.
    /// </summary>
    [JsonPropertyName("publicationId")]
    public string? publicationId { get; set; } = null;

    /// <summary>
    /// The status of the catalog.
    /// </summary>
    [JsonPropertyName("status")]
    public CatalogStatus? status { get; set; } = null;

    /// <summary>
    /// The name of the catalog.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}