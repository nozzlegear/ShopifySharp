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
/// Whether a collection can be referenced as a sub-collection target by another
/// collection's source. Use this to surface ineligible targets up front (with reasons).
/// </summary>
public record CollectionSubCollectionEligibility : IGraphQLObject
{
    /// <summary>
    /// Eligibility for use as an exclusion target of a sub-collection source.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public CollectionSubCollectionEligibilityState? exclusion { get; set; } = null;

    /// <summary>
    /// Eligibility for use as the inclusion target of a sub-collection source.
    /// </summary>
    [JsonPropertyName("inclusion")]
    public CollectionSubCollectionEligibilityState? inclusion { get; set; } = null;
}