#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `abandonmentUpdateActivitiesDeliveryStatuses` mutation.
/// </summary>
public record AbandonmentUpdateActivitiesDeliveryStatusesPayload : IGraphQLObject
{
    /// <summary>
    /// The updated abandonment.
    /// </summary>
    [JsonPropertyName("abandonment")]
    public Abandonment? abandonment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<AbandonmentUpdateActivitiesDeliveryStatusesUserError>? userErrors { get; set; } = null;
}