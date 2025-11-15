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
/// Return type for `taxAppConfigure` mutation.
/// </summary>
public record TaxAppConfigurePayload : IGraphQLObject
{
    /// <summary>
    /// The updated tax app configuration.
    /// </summary>
    [JsonPropertyName("taxAppConfiguration")]
    public TaxAppConfiguration? taxAppConfiguration { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TaxAppConfigureUserError>? userErrors { get; set; } = null;
}