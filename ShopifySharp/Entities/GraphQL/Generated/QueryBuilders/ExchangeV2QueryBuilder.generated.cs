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

public class ExchangeV2QueryBuilder() : GraphQueryBuilder<ExchangeV2>("exchangeV2")
{
    public ExchangeV2QueryBuilder AddFieldAdditions(Func<ExchangeV2AdditionsQueryBuilder, ExchangeV2AdditionsQueryBuilder> build)
    {
        AddField<ExchangeV2Additions, ExchangeV2AdditionsQueryBuilder>("additions", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldMirrored()
    {
        AddField("mirrored");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldRefunds(Func<RefundQueryBuilder, RefundQueryBuilder> build)
    {
        AddField<Refund, RefundQueryBuilder>("refunds", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldReturns(Func<ExchangeV2ReturnsQueryBuilder, ExchangeV2ReturnsQueryBuilder> build)
    {
        AddField<ExchangeV2Returns, ExchangeV2ReturnsQueryBuilder>("returns", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTotalAmountProcessedSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmountProcessedSet", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTransactions(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("transactions", build);
        return this;
    }
}