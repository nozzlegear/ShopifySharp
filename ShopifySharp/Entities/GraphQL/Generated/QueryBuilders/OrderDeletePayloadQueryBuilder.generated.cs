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

public class OrderDeletePayloadQueryBuilder() : GraphQueryBuilder<OrderDeletePayload>("orderDeletePayload")
{
    public OrderDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public OrderDeletePayloadQueryBuilder AddFieldUserErrors(Func<OrderDeleteUserErrorQueryBuilder, OrderDeleteUserErrorQueryBuilder> build)
    {
        AddField<OrderDeleteUserError, OrderDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}