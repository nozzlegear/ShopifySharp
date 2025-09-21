#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible sort of tags.
/// </summary>
public enum ShopTagSort
{
    ALPHABETICAL,
    POPULAR,
}