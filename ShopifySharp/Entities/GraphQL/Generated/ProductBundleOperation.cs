#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An entity that represents details of an asynchronous
/// [ProductBundleCreate](https://shopify.dev/api/admin-graphql/current/mutations/productBundleCreate) or
/// [ProductBundleUpdate](https://shopify.dev/api/admin-graphql/current/mutations/productBundleUpdate) mutation.
/// By querying this entity with the
/// [productOperation](https://shopify.dev/api/admin-graphql/current/queries/productOperation) query
/// using the ID that was returned when the bundle was created or updated, this can be used to check the status of an operation.
/// The `status` field indicates whether the operation is `CREATED`, `ACTIVE`, or `COMPLETE`.
/// The `product` field provides the details of the created or updated product.
/// The `userErrors` field provides mutation errors that occurred during the operation.
/// </summary>
public record ProductBundleOperation : IGraphQLObject, INode, IProductOperation
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
    public ICollection<ProductBundleMutationUserError>? userErrors { get; set; } = null;
}