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

public class OrderEditRemoveDiscountUserErrorQueryBuilder() : GraphQueryBuilder<OrderEditRemoveDiscountUserError>("query orderEditRemoveDiscountUserError")
{
    public OrderEditRemoveDiscountUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OrderEditRemoveDiscountUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OrderEditRemoveDiscountUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}