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

public class TenderTransactionQueryBuilder() : GraphQueryBuilder<TenderTransaction>("tenderTransaction")
{
    public TenderTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldPaymentMethod()
    {
        AddField("paymentMethod");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldRemoteReference()
    {
        AddField("remoteReference");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    public TenderTransactionQueryBuilder AddUnionCaseTransactionDetails(Func<TenderTransactionCreditCardDetailsQueryBuilder, TenderTransactionCreditCardDetailsQueryBuilder> build)
    {
        AddUnion<TenderTransactionCreditCardDetails, TenderTransactionCreditCardDetailsQueryBuilder>("transactionDetails", build);
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}