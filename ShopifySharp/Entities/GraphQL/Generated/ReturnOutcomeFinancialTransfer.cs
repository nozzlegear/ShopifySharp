#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The financial transfer details for the return outcome.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ReturnOutcomeFinancialTransferInvoiceReturnOutcome), typeDiscriminator: "InvoiceReturnOutcome")]
[JsonDerivedType(typeof(ReturnOutcomeFinancialTransferRefundReturnOutcome), typeDiscriminator: "RefundReturnOutcome")]
public record ReturnOutcomeFinancialTransfer : GraphQLObject<ReturnOutcomeFinancialTransfer>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public InvoiceReturnOutcome? AsInvoiceReturnOutcome() => this is ReturnOutcomeFinancialTransferInvoiceReturnOutcome wrapper ? wrapper.Value : null;
	public RefundReturnOutcome? AsRefundReturnOutcome() => this is ReturnOutcomeFinancialTransferRefundReturnOutcome wrapper ? wrapper.Value : null;
#endif
}