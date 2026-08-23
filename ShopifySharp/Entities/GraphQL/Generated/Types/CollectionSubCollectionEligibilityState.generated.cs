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
/// Whether a collection is eligible for one role (inclusion or exclusion) in a
/// sub-collection relationship, plus the reason it isn't if applicable.
/// </summary>
public record CollectionSubCollectionEligibilityState : IGraphQLObject
{
    /// <summary>
    /// Whether the collection can be used in this sub-collection role.
    /// </summary>
    [JsonPropertyName("eligible")]
    public bool? eligible { get; set; } = null;

    /// <summary>
    /// Stable identifier describing why the collection is ineligible. Null when
    /// `eligible` is true. Clients can map this to user-facing copy or use it as a feature flag.
    /// </summary>
    [JsonPropertyName("ineligibleReason")]
    public SubCollectionIneligibleReason? ineligibleReason { get; set; } = null;
}