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
/// Return type for `returnLineItemRemoveFromReturn` mutation.
/// </summary>
public record ReturnLineItemRemoveFromReturnPayload : IGraphQLObject
{
    /// <summary>
    /// The modified return.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}