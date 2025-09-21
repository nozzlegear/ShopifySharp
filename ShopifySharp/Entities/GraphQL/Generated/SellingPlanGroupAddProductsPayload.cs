#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `sellingPlanGroupAddProducts` mutation.
/// </summary>
public record SellingPlanGroupAddProductsPayload : IGraphQLObject
{
    /// <summary>
    /// The updated selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroup")]
    public SellingPlanGroup? sellingPlanGroup { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}