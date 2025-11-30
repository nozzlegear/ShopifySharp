#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder() : GraphQueryBuilder<FulfillmentOrdersSetFulfillmentDeadlineUserError>("query fulfillmentOrdersSetFulfillmentDeadlineUserError")
{
    public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}