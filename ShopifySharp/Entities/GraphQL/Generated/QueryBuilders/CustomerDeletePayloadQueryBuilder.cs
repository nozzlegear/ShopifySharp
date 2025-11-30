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

public class CustomerDeletePayloadQueryBuilder() : GraphQueryBuilder<CustomerDeletePayload>("query customerDeletePayload")
{
    public CustomerDeletePayloadQueryBuilder AddFieldDeletedCustomerId()
    {
        AddField("deletedCustomerId");
        return this;
    }

    public CustomerDeletePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public CustomerDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}