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
/// An interface representing asynchronous operations on products. Tracks the status
/// and details of background product mutations like `productSet`, `productDelete`,
/// `productDuplicate`, and `productBundle` operations. Provides status field
/// (CREATED, ACTIVE, COMPLETE) and product field to monitor long-running product operations.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ProductBundleOperation), typeDiscriminator: "ProductBundleOperation")]
[JsonDerivedType(typeof(ProductDeleteOperation), typeDiscriminator: "ProductDeleteOperation")]
[JsonDerivedType(typeof(ProductDuplicateOperation), typeDiscriminator: "ProductDuplicateOperation")]
[JsonDerivedType(typeof(ProductSetOperation), typeDiscriminator: "ProductSetOperation")]
public interface IProductOperation : IGraphQLObject
{
    /// <summary>
    /// The product on which the operation is being performed.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; }

    /// <summary>
    /// The status of this operation.
    /// </summary>
    [JsonPropertyName("status")]
    public ProductOperationStatus? status { get; set; }
}