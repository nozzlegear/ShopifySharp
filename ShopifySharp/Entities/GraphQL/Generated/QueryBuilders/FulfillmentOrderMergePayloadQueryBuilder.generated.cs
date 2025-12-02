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

public class FulfillmentOrderMergePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMergePayload>("fulfillmentOrderMergePayload")
{
    public FulfillmentOrderMergePayloadQueryBuilder AddFieldFulfillmentOrderMerges(Func<FulfillmentOrderMergeResultQueryBuilder, FulfillmentOrderMergeResultQueryBuilder> build)
    {
        AddField<FulfillmentOrderMergeResult, FulfillmentOrderMergeResultQueryBuilder>("fulfillmentOrderMerges", build);
        return this;
    }

    public FulfillmentOrderMergePayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentOrderMergeUserErrorQueryBuilder, FulfillmentOrderMergeUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentOrderMergeUserError, FulfillmentOrderMergeUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}