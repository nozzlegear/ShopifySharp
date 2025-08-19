#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields and values for creating a customer segment members query.
/// </summary>
public record CustomerSegmentMembersQueryInput : GraphQLInputObject<CustomerSegmentMembersQueryInput>
{
    /// <summary>
    /// The query that's used to filter the members. The query is composed of a
    /// combination of conditions on facts about customers such as
    /// `email_subscription_status = 'SUBSCRIBED'` with [this
    /// syntax](https://shopify.dev/api/shopifyql/segment-query-language-reference).
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;

    /// <summary>
    /// Reverse the order of the list. The sorting behaviour defaults to ascending order.
    /// </summary>
    [JsonPropertyName("reverse")]
    public bool? reverse { get; set; } = null;

    /// <summary>
    /// The ID of the segment.
    /// </summary>
    [JsonPropertyName("segmentId")]
    public string? segmentId { get; set; } = null;

    /// <summary>
    /// Sort the list by a given key.
    /// </summary>
    [JsonPropertyName("sortKey")]
    public string? sortKey { get; set; } = null;
}