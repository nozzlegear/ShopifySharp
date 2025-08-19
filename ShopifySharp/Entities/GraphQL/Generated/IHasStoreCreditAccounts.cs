#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents information about the store credit accounts associated to the specified owner.
/// </summary>
public interface IHasStoreCreditAccounts : IGraphQLObject
{
    /// <summary>
    /// Returns a list of store credit accounts that belong to the owner resource.
    /// A store credit account owner can hold multiple accounts each with a different currency.
    /// </summary>
    [JsonPropertyName("storeCreditAccounts")]
    public StoreCreditAccountConnection? storeCreditAccounts { get; set; }
}