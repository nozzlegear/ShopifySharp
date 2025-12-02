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

public class FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrdersSetFulfillmentDeadlinePayload>("fulfillmentOrdersSetFulfillmentDeadlinePayload")
{
    public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder AddFieldUserErrors(Func<FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder, FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder> build)
    {
        AddField<FulfillmentOrdersSetFulfillmentDeadlineUserError, FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}