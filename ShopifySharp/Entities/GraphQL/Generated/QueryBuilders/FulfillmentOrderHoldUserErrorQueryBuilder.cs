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

public class FulfillmentOrderHoldUserErrorQueryBuilder() : GraphQueryBuilder<FulfillmentOrderHoldUserError>("query fulfillmentOrderHoldUserError")
{
    public FulfillmentOrderHoldUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public FulfillmentOrderHoldUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public FulfillmentOrderHoldUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}