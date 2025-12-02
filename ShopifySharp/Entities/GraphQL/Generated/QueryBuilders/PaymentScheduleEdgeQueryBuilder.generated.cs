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

public class PaymentScheduleEdgeQueryBuilder() : GraphQueryBuilder<PaymentScheduleEdge>("paymentScheduleEdge")
{
    public PaymentScheduleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public PaymentScheduleEdgeQueryBuilder AddFieldNode(Func<PaymentScheduleQueryBuilder, PaymentScheduleQueryBuilder> build)
    {
        AddField<PaymentSchedule, PaymentScheduleQueryBuilder>("node", build);
        return this;
    }
}