#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a merchandising background operation interface.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AddAllProductsOperation), typeDiscriminator: "AddAllProductsOperation")]
[JsonDerivedType(typeof(CatalogCsvOperation), typeDiscriminator: "CatalogCsvOperation")]
[JsonDerivedType(typeof(PublicationResourceOperation), typeDiscriminator: "PublicationResourceOperation")]
public interface IResourceOperation : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The count of processed rows, summing imported, failed, and skipped rows.
    /// </summary>
    [JsonPropertyName("processedRowCount")]
    public int? processedRowCount { get; set; }

    /// <summary>
    /// Represents a rows objects within this background operation.
    /// </summary>
    [JsonPropertyName("rowCount")]
    public RowCount? rowCount { get; set; }

    /// <summary>
    /// The status of this operation.
    /// </summary>
    [JsonPropertyName("status")]
    public ResourceOperationStatus? status { get; set; }
}