#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `sellingPlanGroupCreate` mutation.
/// </summary>
public record SellingPlanGroupCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created selling plan group object.
    /// </summary>
    [JsonPropertyName("sellingPlanGroup")]
    public SellingPlanGroup? sellingPlanGroup { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}