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

public class FulfillmentCreateV2PayloadQueryBuilder() : GraphQueryBuilder<FulfillmentCreateV2Payload>("fulfillmentCreateV2Payload")
{
    public FulfillmentCreateV2PayloadQueryBuilder AddFieldFulfillment(Func<FulfillmentQueryBuilder, FulfillmentQueryBuilder> build)
    {
        AddField<Fulfillment, FulfillmentQueryBuilder>("fulfillment", build);
        return this;
    }

    public FulfillmentCreateV2PayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}