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

public class FulfillmentServiceUpdatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentServiceUpdatePayload>("fulfillmentServiceUpdatePayload")
{
    public FulfillmentServiceUpdatePayloadQueryBuilder AddFieldFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentService", build);
        return this;
    }

    public FulfillmentServiceUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}