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
/// Possible error codes that can be returned by `ArticleUpdateUserError`.
/// </summary>
public enum ArticleUpdateUserErrorCode
{
    AMBIGUOUS_AUTHOR,
    AMBIGUOUS_BLOG,
    AUTHOR_MUST_EXIST,
    INVALID_PUBLISH_DATE,
    UPLOAD_FAILED,
    BLANK,
    NOT_FOUND,
    TOO_LONG,
    TAKEN,
    INVALID,
    INVALID_VALUE,
    INVALID_TYPE,
}