#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TransactionVoidPayloadQueryBuilder() : GraphQueryBuilder<TransactionVoidPayload>("query transactionVoidPayload")
{
    public TransactionVoidPayloadQueryBuilder AddFieldTransaction()
    {
        AddField("transaction");
        return this;
    }

    public TransactionVoidPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}