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
/// An entity that represents details of an asynchronous
/// [ProductDelete](https://shopify.dev/api/admin-graphql/current/mutations/productDelete) mutation.
/// By querying this entity with the
/// [productOperation](https://shopify.dev/api/admin-graphql/current/queries/productOperation) query
/// using the ID that was returned when the product was deleted, this can be used to check the status of an operation.
/// The `status` field indicates whether the operation is `CREATED`, `ACTIVE`, or `COMPLETE`.
/// The `deletedProductId` field provides the ID of the deleted product.
/// The `userErrors` field provides mutation errors that occurred during the operation.
/// </summary>
public record ProductDeleteOperation : IGraphQLObject, INode, IProductOperation
{
    /// <summary>
    /// The ID of the deleted product.
    /// </summary>
    [JsonPropertyName("deletedProductId")]
    public string? deletedProductId { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The product on which the operation is being performed.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The status of this operation.
    /// </summary>
    [JsonPropertyName("status")]
    public ProductOperationStatus? status { get; set; } = null;

    /// <summary>
    /// Returns mutation errors occurred during background mutation processing.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}