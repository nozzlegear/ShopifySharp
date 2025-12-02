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

public class RefundQueryBuilder() : GraphQueryBuilder<Refund>("refund")
{
    public RefundQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public RefundQueryBuilder AddFieldDuties(Func<RefundDutyQueryBuilder, RefundDutyQueryBuilder> build)
    {
        AddField<RefundDuty, RefundDutyQueryBuilder>("duties", build);
        return this;
    }

    public RefundQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public RefundQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public RefundQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public RefundQueryBuilder AddFieldOrderAdjustments(Func<OrderAdjustmentConnectionQueryBuilder, OrderAdjustmentConnectionQueryBuilder> build)
    {
        AddField<OrderAdjustmentConnection, OrderAdjustmentConnectionQueryBuilder>("orderAdjustments", build);
        return this;
    }

    public RefundQueryBuilder AddFieldRefundLineItems(Func<RefundLineItemConnectionQueryBuilder, RefundLineItemConnectionQueryBuilder> build)
    {
        AddField<RefundLineItemConnection, RefundLineItemConnectionQueryBuilder>("refundLineItems", build);
        return this;
    }

    public RefundQueryBuilder AddFieldRefundShippingLines(Func<RefundShippingLineConnectionQueryBuilder, RefundShippingLineConnectionQueryBuilder> build)
    {
        AddField<RefundShippingLineConnection, RefundShippingLineConnectionQueryBuilder>("refundShippingLines", build);
        return this;
    }

    public RefundQueryBuilder AddFieldReturn(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("return", build);
        return this;
    }

    public RefundQueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }

    public RefundQueryBuilder AddFieldTotalRefunded(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalRefunded", build);
        return this;
    }

    public RefundQueryBuilder AddFieldTotalRefundedSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalRefundedSet", build);
        return this;
    }

    public RefundQueryBuilder AddFieldTransactions(Func<OrderTransactionConnectionQueryBuilder, OrderTransactionConnectionQueryBuilder> build)
    {
        AddField<OrderTransactionConnection, OrderTransactionConnectionQueryBuilder>("transactions", build);
        return this;
    }

    public RefundQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}