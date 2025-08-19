#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible sort of tags.
/// </summary>
public enum ArticleTagSort
{
    ALPHABETICAL,
    POPULAR,
}