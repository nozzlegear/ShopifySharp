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
/// All possible instrument outputs for Payment Mandates.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PaymentInstrument>))]
public record PaymentInstrument : GraphQLObject<PaymentInstrument>, IGraphQLUnionType
{
    public BankAccount? AsBankAccount() => this is PaymentInstrumentBankAccount wrapper ? wrapper.Value : null;
    public VaultCreditCard? AsVaultCreditCard() => this is PaymentInstrumentVaultCreditCard wrapper ? wrapper.Value : null;
    public VaultPaypalBillingAgreement? AsVaultPaypalBillingAgreement() => this is PaymentInstrumentVaultPaypalBillingAgreement wrapper ? wrapper.Value : null;
}