#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketingActivitiesDeleteAllExternal` mutation.
/// </summary>
public record MarketingActivitiesDeleteAllExternalPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job that performs the deletion. The status of the job may be
    /// used to determine when it's safe again to create new activities.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}