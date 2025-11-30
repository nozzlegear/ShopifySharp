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

public class PaymentTermsQueryBuilder() : GraphQueryBuilder<PaymentTerms>("paymentTerms")
{
    public PaymentTermsQueryBuilder AddFieldDraftOrder(Func<DraftOrderQueryBuilder, DraftOrderQueryBuilder> build)
    {
        AddField<DraftOrder, DraftOrderQueryBuilder>("draftOrder", build);
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldDueInDays()
    {
        AddField("dueInDays");
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldOverdue()
    {
        AddField("overdue");
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldPaymentSchedules(Func<PaymentScheduleConnectionQueryBuilder, PaymentScheduleConnectionQueryBuilder> build)
    {
        AddField<PaymentScheduleConnection, PaymentScheduleConnectionQueryBuilder>("paymentSchedules", build);
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldPaymentTermsName()
    {
        AddField("paymentTermsName");
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldPaymentTermsType()
    {
        AddField("paymentTermsType");
        return this;
    }

    public PaymentTermsQueryBuilder AddFieldTranslatedName()
    {
        AddField("translatedName");
        return this;
    }
}