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

public class FulfillmentOrderMovePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMovePayload>("fulfillmentOrderMovePayload")
{
    public FulfillmentOrderMovePayloadQueryBuilder AddFieldMovedFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("movedFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldOriginalFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("originalFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldRemainingFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("remainingFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}