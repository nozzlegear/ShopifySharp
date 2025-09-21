#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `sellingPlanGroupUpdate` mutation.
/// </summary>
public record SellingPlanGroupUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The IDs of the deleted Subscription Plans.
    /// </summary>
    [JsonPropertyName("deletedSellingPlanIds")]
    public ICollection<string>? deletedSellingPlanIds { get; set; } = null;

    /// <summary>
    /// The updated Selling Plan Group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroup")]
    public SellingPlanGroup? sellingPlanGroup { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}