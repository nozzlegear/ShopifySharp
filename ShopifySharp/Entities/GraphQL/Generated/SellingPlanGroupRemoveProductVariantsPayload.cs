#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `sellingPlanGroupRemoveProductVariants` mutation.
/// </summary>
public record SellingPlanGroupRemoveProductVariantsPayload : IGraphQLObject
{
    /// <summary>
    /// The removed product variant ids.
    /// </summary>
    [JsonPropertyName("removedProductVariantIds")]
    public ICollection<string>? removedProductVariantIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}