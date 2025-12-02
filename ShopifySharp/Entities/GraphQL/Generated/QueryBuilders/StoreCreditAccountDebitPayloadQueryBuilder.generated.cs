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

public class StoreCreditAccountDebitPayloadQueryBuilder() : GraphQueryBuilder<StoreCreditAccountDebitPayload>("storeCreditAccountDebitPayload")
{
    public StoreCreditAccountDebitPayloadQueryBuilder AddFieldStoreCreditAccountTransaction(Func<StoreCreditAccountDebitTransactionQueryBuilder, StoreCreditAccountDebitTransactionQueryBuilder> build)
    {
        AddField<StoreCreditAccountDebitTransaction, StoreCreditAccountDebitTransactionQueryBuilder>("storeCreditAccountTransaction", build);
        return this;
    }

    public StoreCreditAccountDebitPayloadQueryBuilder AddFieldUserErrors(Func<StoreCreditAccountDebitUserErrorQueryBuilder, StoreCreditAccountDebitUserErrorQueryBuilder> build)
    {
        AddField<StoreCreditAccountDebitUserError, StoreCreditAccountDebitUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}