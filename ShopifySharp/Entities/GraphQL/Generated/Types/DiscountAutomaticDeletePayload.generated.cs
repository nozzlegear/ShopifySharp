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
/// Return type for `discountAutomaticDelete` mutation.
/// </summary>
public record DiscountAutomaticDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the automatic discount that was deleted.
    /// </summary>
    [JsonPropertyName("deletedAutomaticDiscountId")]
    public string? deletedAutomaticDiscountId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}