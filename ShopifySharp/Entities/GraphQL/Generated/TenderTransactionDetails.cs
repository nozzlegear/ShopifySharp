#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about the payment instrument used for this transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(TenderTransactionCreditCardDetails), typeDiscriminator: "TenderTransactionCreditCardDetails")]
public record TenderTransactionDetails : GraphQLObject<TenderTransactionDetails>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public TenderTransactionCreditCardDetails? AsTenderTransactionCreditCardDetails() => this is TenderTransactionDetailsTenderTransactionCreditCardDetails wrapper ? wrapper.Value : null;
#endif
}