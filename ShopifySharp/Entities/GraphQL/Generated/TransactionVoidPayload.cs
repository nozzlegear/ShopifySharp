#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `transactionVoid` mutation.
/// </summary>
public record TransactionVoidPayload : IGraphQLObject
{
    /// <summary>
    /// The created void transaction.
    /// </summary>
    [JsonPropertyName("transaction")]
    public OrderTransaction? transaction { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TransactionVoidUserError>? userErrors { get; set; } = null;
}