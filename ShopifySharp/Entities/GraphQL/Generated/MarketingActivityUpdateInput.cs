#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a marketing activity. Marketing activity app
/// extensions are deprecated and will be removed in the near future.
/// </summary>
public record MarketingActivityUpdateInput : GraphQLInputObject<MarketingActivityUpdateInput>
{
    /// <summary>
    /// The ID of the marketing activity.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}