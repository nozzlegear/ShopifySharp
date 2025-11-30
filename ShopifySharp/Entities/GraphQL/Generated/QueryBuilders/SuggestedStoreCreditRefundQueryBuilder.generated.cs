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

public class SuggestedStoreCreditRefundQueryBuilder() : GraphQueryBuilder<SuggestedStoreCreditRefund>("suggestedStoreCreditRefund")
{
    public SuggestedStoreCreditRefundQueryBuilder AddFieldAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amount", build);
        return this;
    }

    public SuggestedStoreCreditRefundQueryBuilder AddFieldExpiresAt()
    {
        AddField("expiresAt");
        return this;
    }

    public SuggestedStoreCreditRefundQueryBuilder AddFieldMaximumRefundable(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundable", build);
        return this;
    }
}