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

public class PaymentScheduleConnectionQueryBuilder() : GraphQueryBuilder<PaymentScheduleConnection>("paymentScheduleConnection")
{
    public PaymentScheduleConnectionQueryBuilder AddFieldEdges(Func<PaymentScheduleEdgeQueryBuilder, PaymentScheduleEdgeQueryBuilder> build)
    {
        AddField<PaymentScheduleEdge, PaymentScheduleEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PaymentScheduleConnectionQueryBuilder AddFieldNodes(Func<PaymentScheduleQueryBuilder, PaymentScheduleQueryBuilder> build)
    {
        AddField<PaymentSchedule, PaymentScheduleQueryBuilder>("nodes", build);
        return this;
    }

    public PaymentScheduleConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}