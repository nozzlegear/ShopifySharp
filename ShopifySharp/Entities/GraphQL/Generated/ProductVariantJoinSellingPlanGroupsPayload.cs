#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productVariantJoinSellingPlanGroups` mutation.
/// </summary>
public record ProductVariantJoinSellingPlanGroupsPayload : IGraphQLObject
{
    /// <summary>
    /// The product variant object.
    /// </summary>
    [JsonPropertyName("productVariant")]
    public ProductVariant? productVariant { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}