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
/// Return type for `discountCodeAppCreate` mutation.
/// </summary>
public record DiscountCodeAppCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The discount that the app provides.
    /// </summary>
    [JsonPropertyName("codeAppDiscount")]
    public DiscountCodeApp? codeAppDiscount { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}