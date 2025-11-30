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

public class OrderCreateMandatePaymentPayloadQueryBuilder() : GraphQueryBuilder<OrderCreateMandatePaymentPayload>("orderCreateMandatePaymentPayload")
{
    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldPaymentReferenceId()
    {
        AddField("paymentReferenceId");
        return this;
    }

    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldUserErrors(Func<OrderCreateMandatePaymentUserErrorQueryBuilder, OrderCreateMandatePaymentUserErrorQueryBuilder> build)
    {
        AddField<OrderCreateMandatePaymentUserError, OrderCreateMandatePaymentUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}