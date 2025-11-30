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

public class FulfillmentOrderReschedulePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderReschedulePayload>("fulfillmentOrderReschedulePayload")
{
    public FulfillmentOrderReschedulePayloadQueryBuilder AddFieldFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("fulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderReschedulePayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentOrderRescheduleUserErrorQueryBuilder, FulfillmentOrderRescheduleUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentOrderRescheduleUserError, FulfillmentOrderRescheduleUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}