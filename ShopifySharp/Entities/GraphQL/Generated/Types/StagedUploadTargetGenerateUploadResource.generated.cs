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
/// The resource type to receive.
/// </summary>
public enum StagedUploadTargetGenerateUploadResource
{
    COLLECTION_IMAGE,
    FILE,
    IMAGE,
    MODEL_3D,
    [Obsolete("Use IMAGE instead. This resource type will be removed in a future version.")]
    PRODUCT_IMAGE,
    SHOP_IMAGE,
    VIDEO,
    BULK_MUTATION_VARIABLES,
    RETURN_LABEL,
    URL_REDIRECT_IMPORT,
    DISPUTE_FILE_UPLOAD,
}