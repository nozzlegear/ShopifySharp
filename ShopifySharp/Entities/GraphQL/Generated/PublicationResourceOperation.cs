#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record PublicationOperationAddAllProductsOperation(AddAllProductsOperation Value): PublicationOperation;
internal record PublicationOperationCatalogCsvOperation(CatalogCsvOperation Value): PublicationOperation;
internal record PublicationOperationPublicationResourceOperation(PublicationResourceOperation Value): PublicationOperation;
#endif /// <summary>

/// A bulk update operation on a publication.
/// </summary>
public record PublicationResourceOperation : PublicationOperation, IGraphQLUnionCase, IGraphQLObject, INode, IResourceOperation
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The count of processed rows, summing imported, failed, and skipped rows.
    /// </summary>
    [JsonPropertyName("processedRowCount")]
    public int? processedRowCount { get; set; } = null;

    /// <summary>
    /// Represents a rows objects within this background operation.
    /// </summary>
    [JsonPropertyName("rowCount")]
    public RowCount? rowCount { get; set; } = null;

    /// <summary>
    /// The status of this operation.
    /// </summary>
    [JsonPropertyName("status")]
    public ResourceOperationStatus? status { get; set; } = null;
}