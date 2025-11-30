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

public class FulfillmentEventCreatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentEventCreatePayload>("fulfillmentEventCreatePayload")
{
    public FulfillmentEventCreatePayloadQueryBuilder AddFieldFulfillmentEvent(Func<FulfillmentEventQueryBuilder, FulfillmentEventQueryBuilder> build)
    {
        AddField<FulfillmentEvent, FulfillmentEventQueryBuilder>("fulfillmentEvent", build);
        return this;
    }

    public FulfillmentEventCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}