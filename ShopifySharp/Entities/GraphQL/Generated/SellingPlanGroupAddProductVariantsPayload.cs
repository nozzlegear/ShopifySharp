#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `sellingPlanGroupAddProductVariants` mutation.
/// </summary>
public record SellingPlanGroupAddProductVariantsPayload : IGraphQLObject
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