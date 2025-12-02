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

public class PaymentScheduleQueryBuilder() : GraphQueryBuilder<PaymentSchedule>("paymentSchedule")
{
    public PaymentScheduleQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public PaymentScheduleQueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public PaymentScheduleQueryBuilder AddFieldDueAt()
    {
        AddField("dueAt");
        return this;
    }

    public PaymentScheduleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PaymentScheduleQueryBuilder AddFieldIssuedAt()
    {
        AddField("issuedAt");
        return this;
    }

    public PaymentScheduleQueryBuilder AddFieldPaymentTerms(Func<PaymentTermsQueryBuilder, PaymentTermsQueryBuilder> build)
    {
        AddField<PaymentTerms, PaymentTermsQueryBuilder>("paymentTerms", build);
        return this;
    }
}