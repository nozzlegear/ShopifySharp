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

public class RefundReturnOutcomeQueryBuilder() : GraphQueryBuilder<RefundReturnOutcome>("refundReturnOutcome")
{
    public RefundReturnOutcomeQueryBuilder AddFieldAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amount", build);
        return this;
    }

    public RefundReturnOutcomeQueryBuilder AddFieldSuggestedRefundMethods(Func<SuggestedRefundMethodQueryBuilder, SuggestedRefundMethodQueryBuilder> build)
    {
        AddField<ISuggestedRefundMethod, SuggestedRefundMethodQueryBuilder>("suggestedRefundMethods", build);
        return this;
    }

    public RefundReturnOutcomeQueryBuilder AddFieldSuggestedTransactions(Func<SuggestedOrderTransactionQueryBuilder, SuggestedOrderTransactionQueryBuilder> build)
    {
        AddField<SuggestedOrderTransaction, SuggestedOrderTransactionQueryBuilder>("suggestedTransactions", build);
        return this;
    }
}