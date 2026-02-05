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
/// Possible error codes that can be returned by `ArticleCreateUserError`.
/// </summary>
public enum ArticleCreateUserErrorCode
{
    AMBIGUOUS_AUTHOR,
    AMBIGUOUS_BLOG,
    AUTHOR_FIELD_REQUIRED,
    AUTHOR_MUST_EXIST,
    INVALID_PUBLISH_DATE,
    BLOG_REFERENCE_REQUIRED,
    UPLOAD_FAILED,
    BLANK,
    NOT_FOUND,
    TOO_LONG,
    TAKEN,
    INVALID,
    INVALID_VALUE,
    INVALID_TYPE,
}