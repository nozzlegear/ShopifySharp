#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the Segment query.
/// </summary>
public enum SegmentSortKeys
{
    CREATION_DATE,
    ID,
    LAST_EDIT_DATE,
    RELEVANCE,
}