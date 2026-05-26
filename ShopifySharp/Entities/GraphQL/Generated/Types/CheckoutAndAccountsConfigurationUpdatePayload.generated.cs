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
/// Return type for `checkoutAndAccountsConfigurationUpdate` mutation.
/// </summary>
public record CheckoutAndAccountsConfigurationUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated configuration.
    /// </summary>
    [JsonPropertyName("configuration")]
    public CheckoutAndAccountsConfiguration? configuration { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CheckoutAndAccountsConfigurationUserError>? userErrors { get; set; } = null;
}