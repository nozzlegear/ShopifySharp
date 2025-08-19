#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `UrlRedirectBulkDeleteBySavedSearchUserError`.
/// </summary>
public enum UrlRedirectBulkDeleteBySavedSearchUserErrorCode
{
    SAVED_SEARCH_NOT_FOUND,
    INVALID_SAVED_SEARCH_QUERY,
}