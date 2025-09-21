#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a marketing activity. Marketing activity app
/// extensions are deprecated and will be removed in the near future.
/// </summary>
public record MarketingActivityCreateInput : GraphQLInputObject<MarketingActivityCreateInput>
{
    /// <summary>
    /// The ID of the marketing activity extension.
    /// </summary>
    [JsonPropertyName("marketingActivityExtensionId")]
    public string? marketingActivityExtensionId { get; set; } = null;

    /// <summary>
    /// The current state of the marketing activity.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketingActivityStatus? status { get; set; } = null;
}