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

public class FulfillmentOrderSplitUserErrorQueryBuilder() : GraphQueryBuilder<FulfillmentOrderSplitUserError>("query fulfillmentOrderSplitUserError")
{
    public FulfillmentOrderSplitUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public FulfillmentOrderSplitUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public FulfillmentOrderSplitUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}