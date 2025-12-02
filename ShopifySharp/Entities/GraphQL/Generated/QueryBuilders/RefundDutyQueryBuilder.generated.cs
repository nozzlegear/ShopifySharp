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

public class RefundDutyQueryBuilder() : GraphQueryBuilder<RefundDuty>("refundDuty")
{
    public RefundDutyQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public RefundDutyQueryBuilder AddFieldOriginalDuty(Func<DutyQueryBuilder, DutyQueryBuilder> build)
    {
        AddField<Duty, DutyQueryBuilder>("originalDuty", build);
        return this;
    }
}