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
/// An entity that represents details of an asynchronous operation on a product.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
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