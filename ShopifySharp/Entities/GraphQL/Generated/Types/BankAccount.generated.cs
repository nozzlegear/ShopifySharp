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
/// Represents a bank account payment instrument.
/// </summary>
public record BankAccount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The type of account holder.
    /// </summary>
    [JsonPropertyName("accountHolderType")]
    public BankAccountHolderType? accountHolderType { get; set; } = null;

    /// <summary>
    /// The type of bank account.
    /// </summary>
    [JsonPropertyName("accountType")]
    public BankAccountType? accountType { get; set; } = null;

    /// <summary>
    /// The name of the bank.
    /// </summary>
    [JsonPropertyName("bankName")]
    public string? bankName { get; set; } = null;

    /// <summary>
    /// The billing address associated with the bank account.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CustomerPaymentInstrumentBillingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The last four digits of the account number.
    /// </summary>
    [JsonPropertyName("lastDigits")]
    public string? lastDigits { get; set; } = null;
}