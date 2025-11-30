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

public class FulfillmentOrderReleaseHoldPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderReleaseHoldPayload>("fulfillmentOrderReleaseHoldPayload")
{
    public FulfillmentOrderReleaseHoldPayloadQueryBuilder AddFieldFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("fulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderReleaseHoldPayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentOrderReleaseHoldUserErrorQueryBuilder, FulfillmentOrderReleaseHoldUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentOrderReleaseHoldUserError, FulfillmentOrderReleaseHoldUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}