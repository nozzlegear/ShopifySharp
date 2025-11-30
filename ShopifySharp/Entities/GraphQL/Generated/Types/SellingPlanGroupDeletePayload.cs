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
/// Return type for `sellingPlanGroupDelete` mutation.
/// </summary>
public record SellingPlanGroupDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted selling plan group object.
    /// </summary>
    [JsonPropertyName("deletedSellingPlanGroupId")]
    public string? deletedSellingPlanGroupId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SellingPlanGroupUserError>? userErrors { get; set; } = null;
}