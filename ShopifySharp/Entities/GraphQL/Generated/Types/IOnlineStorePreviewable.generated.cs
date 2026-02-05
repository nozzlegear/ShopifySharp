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
/// Online Store preview URL of the object.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
public interface IOnlineStorePreviewable : IGraphQLObject
{
    /// <summary>
    /// The [preview URL](https://help.shopify.com/manual/online-store/setting-up#preview-your-store) for the online store.
    /// </summary>
    [JsonPropertyName("onlineStorePreviewUrl")]
    public string? onlineStorePreviewUrl { get; set; }
}