#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `storeCreditAccountCredit` mutation.
/// </summary>
public record StoreCreditAccountCreditPayload : IGraphQLObject
{
    /// <summary>
    /// The store credit account transaction that was created.
    /// </summary>
    [JsonPropertyName("storeCreditAccountTransaction")]
    public StoreCreditAccountCreditTransaction? storeCreditAccountTransaction { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<StoreCreditAccountCreditUserError>? userErrors { get; set; } = null;
}