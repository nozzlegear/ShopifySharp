#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible HTTP methods that can be used when sending a request to upload a file using information from a
/// [StagedMediaUploadTarget](https://shopify.dev/api/admin-graphql/latest/objects/StagedMediaUploadTarget).
/// </summary>
public enum StagedUploadHttpMethodType
{
    POST,
    PUT,
}