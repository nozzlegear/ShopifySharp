#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An entity that represents details of an asynchronous
/// [ProductDuplicate](https://shopify.dev/api/admin-graphql/current/mutations/productDuplicate) mutation.
/// By querying this entity with the
/// [productOperation](https://shopify.dev/api/admin-graphql/current/queries/productOperation) query
/// using the ID that was returned
/// [when the product was duplicated](https://shopify.dev/api/admin/migrate/new-product-model/sync-data#create-a-product-with-variants-and-options-asynchronously),
/// this can be used to check the status of an operation.
/// The `status` field indicates whether the operation is `CREATED`, `ACTIVE`, or `COMPLETE`.
/// The `product` field provides the details of the original product.
/// The `newProduct` field provides the details of the new duplicate of the product.
/// The `userErrors` field provides mutation errors that occurred during the operation.
/// </summary>
public record ProductDuplicateOperation : IGraphQLObject, INode, IProductOperation
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The newly created duplicate of the original product.
    /// </summary>
    [JsonPropertyName("newProduct")]
    public Product? newProduct { get; set; } = null;

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