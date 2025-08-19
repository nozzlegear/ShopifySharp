#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid values for the status of product feed.
/// </summary>
public enum ProductFeedStatus
{
    ACTIVE,
    INACTIVE,
}