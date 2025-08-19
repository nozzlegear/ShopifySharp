#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record TenderTransactionDetailsTenderTransactionCreditCardDetails(TenderTransactionCreditCardDetails Value): TenderTransactionDetails;
#endif /// <summary>

/// An auto-generated type which holds one TenderTransaction and a cursor during pagination.
/// </summary>
public record TenderTransactionEdge : Edge<TenderTransaction?>
{
}