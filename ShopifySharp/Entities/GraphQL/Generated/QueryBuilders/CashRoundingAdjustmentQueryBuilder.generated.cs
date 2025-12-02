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

public class CashRoundingAdjustmentQueryBuilder() : GraphQueryBuilder<CashRoundingAdjustment>("cashRoundingAdjustment")
{
    public CashRoundingAdjustmentQueryBuilder AddFieldPaymentSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("paymentSet", build);
        return this;
    }

    public CashRoundingAdjustmentQueryBuilder AddFieldRefundSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("refundSet", build);
        return this;
    }
}