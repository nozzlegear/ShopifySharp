#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `discountAutomaticAppCreate` mutation.
/// </summary>
public record DiscountAutomaticAppCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The automatic discount that the app manages.
    /// </summary>
    [JsonPropertyName("automaticAppDiscount")]
    public DiscountAutomaticApp? automaticAppDiscount { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}