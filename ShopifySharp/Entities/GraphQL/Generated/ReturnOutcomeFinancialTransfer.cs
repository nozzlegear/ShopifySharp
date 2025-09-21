#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The financial transfer details for the return outcome.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<ReturnOutcomeFinancialTransfer>))]
public record ReturnOutcomeFinancialTransfer : GraphQLObject<ReturnOutcomeFinancialTransfer>, IGraphQLUnionType
{
    public InvoiceReturnOutcome? AsInvoiceReturnOutcome() => this is ReturnOutcomeFinancialTransferInvoiceReturnOutcome wrapper ? wrapper.Value : null;
    public RefundReturnOutcome? AsRefundReturnOutcome() => this is ReturnOutcomeFinancialTransferRefundReturnOutcome wrapper ? wrapper.Value : null;
}