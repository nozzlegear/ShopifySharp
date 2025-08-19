#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An entity that represents details of an asynchronous
/// [ProductSet](https://shopify.dev/api/admin-graphql/current/mutations/productSet) mutation.
/// By querying this entity with the
/// [productOperation](https://shopify.dev/api/admin-graphql/current/queries/productOperation) query
/// using the ID that was returned
/// [when the product was created or updated](https://shopify.dev/api/admin/migrate/new-product-model/sync-data#create-a-product-with-variants-and-options-asynchronously),
/// this can be used to check the status of an operation.
/// The `status` field indicates whether the operation is `CREATED`, `ACTIVE`, or `COMPLETE`.
/// The `product` field provides the details of the created or updated product.
/// The `userErrors` field provides mutation errors that occurred during the operation.
/// </summary>
public record ProductSetOperation : IGraphQLObject, INode, IProductOperation
{
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
    public ICollection<ProductSetUserError>? userErrors { get; set; } = null;
}