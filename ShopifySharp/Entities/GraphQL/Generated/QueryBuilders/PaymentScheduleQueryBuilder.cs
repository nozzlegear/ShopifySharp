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

public class PaymentScheduleQueryBuilder() : GraphQueryBuilder<PaymentSchedule>("query paymentSchedule")
{
    [Obsolete("Use `balanceDue`, `totalBalance`, or `Order.totalOutstandingSet` instead.")]
    public PaymentScheduleQueryBuilder AddFieldAmount()
    {
        AddField("amount");
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

    public PaymentScheduleQueryBuilder AddFieldPaymentTerms()
    {
        AddField("paymentTerms");
        return this;
    }
}