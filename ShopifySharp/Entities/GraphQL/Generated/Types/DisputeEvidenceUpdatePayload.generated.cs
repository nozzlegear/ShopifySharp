#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `disputeEvidenceUpdate` mutation.
/// </summary>
public record DisputeEvidenceUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated dispute evidence.
    /// </summary>
    [JsonPropertyName("disputeEvidence")]
    public ShopifyPaymentsDisputeEvidence? disputeEvidence { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DisputeEvidenceUpdateUserError>? userErrors { get; set; } = null;
}