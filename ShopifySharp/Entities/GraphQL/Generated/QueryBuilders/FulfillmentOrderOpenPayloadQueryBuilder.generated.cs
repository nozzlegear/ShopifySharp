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

public class FulfillmentOrderOpenPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderOpenPayload>("fulfillmentOrderOpenPayload")
{
    public FulfillmentOrderOpenPayloadQueryBuilder AddFieldFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("fulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderOpenPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}