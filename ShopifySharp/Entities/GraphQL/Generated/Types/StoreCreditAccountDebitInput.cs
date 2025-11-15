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
/// The input fields for a store credit account debit transaction.
/// </summary>
public record StoreCreditAccountDebitInput : GraphQLInputObject<StoreCreditAccountDebitInput>
{
    /// <summary>
    /// The amount to debit the store credit account.
    /// </summary>
    [JsonPropertyName("debitAmount")]
    public MoneyInput? debitAmount { get; set; } = null;
}