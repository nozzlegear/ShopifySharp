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
/// The set of valid sort keys for the File query.
/// </summary>
public enum FileSortKeys
{
    CREATED_AT,
    FILENAME,
    ID,
    ORIGINAL_UPLOAD_SIZE,
    RELEVANCE,
    UPDATED_AT,
}