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

public class OrderCustomerRemoveUserErrorQueryBuilder() : GraphQueryBuilder<OrderCustomerRemoveUserError>("query orderCustomerRemoveUserError")
{
    public OrderCustomerRemoveUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OrderCustomerRemoveUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OrderCustomerRemoveUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}