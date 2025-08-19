#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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