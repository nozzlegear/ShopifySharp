#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The resource type to receive.
/// </summary>
public enum StagedUploadTargetGenerateUploadResource
{
    COLLECTION_IMAGE,
    FILE,
    IMAGE,
    MODEL_3D,
    PRODUCT_IMAGE,
    SHOP_IMAGE,
    VIDEO,
    BULK_MUTATION_VARIABLES,
    RETURN_LABEL,
    URL_REDIRECT_IMPORT,
}