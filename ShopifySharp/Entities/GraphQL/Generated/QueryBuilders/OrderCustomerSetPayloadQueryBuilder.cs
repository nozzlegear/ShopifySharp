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

public class OrderCustomerSetPayloadQueryBuilder() : GraphQueryBuilder<OrderCustomerSetPayload>("query orderCustomerSetPayload")
{
    public OrderCustomerSetPayloadQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderCustomerSetPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}