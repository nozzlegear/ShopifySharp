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

public class ShopifyPaymentsAssociatedOrderQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAssociatedOrder>("shopifyPaymentsAssociatedOrder")
{
    public ShopifyPaymentsAssociatedOrderQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsAssociatedOrderQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}