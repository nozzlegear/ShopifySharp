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
/// Return type for `storeCreditAccountDebit` mutation.
/// </summary>
public record StoreCreditAccountDebitPayload : IGraphQLObject
{
    /// <summary>
    /// The store credit account transaction that was created.
    /// </summary>
    [JsonPropertyName("storeCreditAccountTransaction")]
    public StoreCreditAccountDebitTransaction? storeCreditAccountTransaction { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<StoreCreditAccountDebitUserError>? userErrors { get; set; } = null;
}