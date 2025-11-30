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

public class OrderAppQueryBuilder() : GraphQueryBuilder<OrderApp>("query orderApp")
{
    public OrderAppQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public OrderAppQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderAppQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}