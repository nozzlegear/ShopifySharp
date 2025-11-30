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

public class RefundReturnOutcomeQueryBuilder() : GraphQueryBuilder<RefundReturnOutcome>("query refundReturnOutcome")
{
    public RefundReturnOutcomeQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public RefundReturnOutcomeQueryBuilder AddFieldSuggestedRefundMethods()
    {
        AddField("suggestedRefundMethods");
        return this;
    }

    public RefundReturnOutcomeQueryBuilder AddFieldSuggestedTransactions()
    {
        AddField("suggestedTransactions");
        return this;
    }
}