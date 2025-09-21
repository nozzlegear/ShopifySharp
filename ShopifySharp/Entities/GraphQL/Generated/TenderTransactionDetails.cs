#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Information about the payment instrument used for this transaction.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<TenderTransactionDetails>))]
public record TenderTransactionDetails : GraphQLObject<TenderTransactionDetails>, IGraphQLUnionType
{
    public TenderTransactionCreditCardDetails? AsTenderTransactionCreditCardDetails() => this is TenderTransactionDetailsTenderTransactionCreditCardDetails wrapper ? wrapper.Value : null;
}