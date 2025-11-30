#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TransactionVoidPayloadQueryBuilder() : GraphQueryBuilder<TransactionVoidPayload>("transactionVoidPayload")
{
    public TransactionVoidPayloadQueryBuilder AddFieldTransaction(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("transaction", build);
        return this;
    }

    public TransactionVoidPayloadQueryBuilder AddFieldUserErrors(Func<TransactionVoidUserErrorQueryBuilder, TransactionVoidUserErrorQueryBuilder> build)
    {
        AddField<TransactionVoidUserError, TransactionVoidUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}