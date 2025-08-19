#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Online Store preview URL of the object.
/// </summary>
public interface IOnlineStorePreviewable : IGraphQLObject
{
    /// <summary>
    /// The [preview URL](https://help.shopify.com/manual/online-store/setting-up#preview-your-store) for the online store.
    /// </summary>
    [JsonPropertyName("onlineStorePreviewUrl")]
    public string? onlineStorePreviewUrl { get; set; }
}