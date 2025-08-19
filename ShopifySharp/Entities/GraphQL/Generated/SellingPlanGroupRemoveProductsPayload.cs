#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `sellingPlanGroupRemoveProducts` mutation.
/// </summary>
public record SellingPlanGroupRemoveProductsPayload : IGraphQLObject
{
    /// <summary>
    /// The removed product ids.
    /// </summary>
    [JsonPropertyName("removedProductIds")]
    public ICollection<string>? removedProductIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}