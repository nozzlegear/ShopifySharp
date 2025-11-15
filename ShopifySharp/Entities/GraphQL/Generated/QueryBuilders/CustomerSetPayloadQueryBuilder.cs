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

public class CustomerSetPayloadQueryBuilder() : GraphQueryBuilder<CustomerSetPayload>("query customerSetPayload")
{
    public CustomerSetPayloadQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public CustomerSetPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}