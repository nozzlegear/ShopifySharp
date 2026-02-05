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
/// Return type for `discountAutomaticAppUpdate` mutation.
/// </summary>
public record DiscountAutomaticAppUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated automatic discount that the app provides.
    /// </summary>
    [JsonPropertyName("automaticAppDiscount")]
    public DiscountAutomaticApp? automaticAppDiscount { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}