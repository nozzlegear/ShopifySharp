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

public class OrderEditUpdateShippingLineUserErrorQueryBuilder() : GraphQueryBuilder<OrderEditUpdateShippingLineUserError>("query orderEditUpdateShippingLineUserError")
{
    public OrderEditUpdateShippingLineUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OrderEditUpdateShippingLineUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OrderEditUpdateShippingLineUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}