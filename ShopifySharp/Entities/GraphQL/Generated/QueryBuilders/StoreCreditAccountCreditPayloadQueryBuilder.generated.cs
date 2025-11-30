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

public class StoreCreditAccountCreditPayloadQueryBuilder() : GraphQueryBuilder<StoreCreditAccountCreditPayload>("storeCreditAccountCreditPayload")
{
    public StoreCreditAccountCreditPayloadQueryBuilder AddFieldStoreCreditAccountTransaction(Func<StoreCreditAccountCreditTransactionQueryBuilder, StoreCreditAccountCreditTransactionQueryBuilder> build)
    {
        AddField<StoreCreditAccountCreditTransaction, StoreCreditAccountCreditTransactionQueryBuilder>("storeCreditAccountTransaction", build);
        return this;
    }

    public StoreCreditAccountCreditPayloadQueryBuilder AddFieldUserErrors(Func<StoreCreditAccountCreditUserErrorQueryBuilder, StoreCreditAccountCreditUserErrorQueryBuilder> build)
    {
        AddField<StoreCreditAccountCreditUserError, StoreCreditAccountCreditUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}