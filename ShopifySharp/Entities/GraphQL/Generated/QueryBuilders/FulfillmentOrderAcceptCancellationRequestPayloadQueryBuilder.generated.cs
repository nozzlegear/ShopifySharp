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

public class FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderAcceptCancellationRequestPayload>("fulfillmentOrderAcceptCancellationRequestPayload")
{
    public FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder AddFieldFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("fulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}