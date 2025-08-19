#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketingEngagementsDelete` mutation.
/// </summary>
public record MarketingEngagementsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// Informational message about the engagement data that has been marked for deletion.
    /// </summary>
    [JsonPropertyName("result")]
    public string? result { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}