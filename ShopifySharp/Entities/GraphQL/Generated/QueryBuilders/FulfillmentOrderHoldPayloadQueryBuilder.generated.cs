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

public class FulfillmentOrderHoldPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderHoldPayload>("fulfillmentOrderHoldPayload")
{
    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldFulfillmentHold(Func<FulfillmentHoldQueryBuilder, FulfillmentHoldQueryBuilder> build)
    {
        AddField<FulfillmentHold, FulfillmentHoldQueryBuilder>("fulfillmentHold", build);
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("fulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldRemainingFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("remainingFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentOrderHoldUserErrorQueryBuilder, FulfillmentOrderHoldUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentOrderHoldUserError, FulfillmentOrderHoldUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}